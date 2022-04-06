namespace homework4
{
    public partial class Form1 : Form
    {

        delegate void BikeAction(Button bike);
        Random random = new Random();
        // Manual reset for the Step1
        private ManualResetEvent Step1 = new ManualResetEvent(false);
        // Auto reset for the Step2
        private AutoResetEvent Step2 = new AutoResetEvent(false);
        // needed variables for pixels
        private long count;
        private object syncRoot = new object();
        //startin posiotion for the bikes
        private int startPosition;
        public Form1()
        {
            InitializeComponent();
            //initialization of start position
            startPosition = bBike1.Left;
        }
        public void BikeThreadFunction(object param)
        {
            try
            {
                Button bike = (Button)param;
                bike.Tag = Thread.CurrentThread;

                while (bike.Left < pStart.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
                if (Step1.WaitOne())
                {
                    while (bike.Left < pDepo.Left)
                    {
                        MoveBike(bike);
                        Thread.Sleep(100);
                    }
                }
                if (Step2.WaitOne())
                {
                    while (bike.Left < pTarget.Left)
                    {
                        MoveBike(bike);
                        Thread.Sleep(100);
                    }
                }

            }
            catch (ThreadInterruptedException)
            {

            }
        }
        public void MoveBike(Button bike)
        {
            if (InvokeRequired)
            {
                Invoke(new BikeAction(MoveBike), bike);
            }
            else
            {
                int rand = new Random().Next(10);
                bike.Left += rand;
                //increment counter by pixels taken
                increaseCounter(rand);
            }
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            StartBike(bBike1);
            StartBike(bBike2);
            StartBike(bBike3);
        }
        private void StartBike(Button bBike)
        {
            Thread t = new Thread(BikeThreadFunction);
            bBike.Tag = t;
            t.IsBackground = true; // The thread wont prevent closing the process.
            t.Start(bBike);
        }

        private void bStep1_Click(object sender, EventArgs e)
        {
            if (bBike1.Left >= pStart.Left && bBike2.Left >= pStart.Left && bBike3.Left >= pStart.Left)
            {
                Step1.Set();
            }
        }

        private void bStep2_Click(object sender, EventArgs e)
        {
            Step2.Set();
        }
        public void increaseCounter(long step)
        {

            lock (syncRoot)
            {
                count += step;
            }
        }
        public long getCounter()
        {
            lock (syncRoot)
            {
                return count; //get counter value to display the distance
            }
        }

        private void bike_Click(object sender, EventArgs e)
        {
            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;
            // This is null, if we haven’t yet started the thread .
            if (thread == null)
                return;
            // Interrupt the blocking in the thread. This will cause a
            // ThreadInterruptedException in the target thread.
            thread.Interrupt();
            // Let’s wait the thread to exit.
            thread.Join();
            //reset step1
            Step1.Reset();
            //Return the bike to starting position
            bike.Left = startPosition;
        }

        private void bCounter_Click(object sender, EventArgs e)
        {
            // display distance in pixels in button
            bCounter.Text = getCounter().ToString();
        }


    }
}