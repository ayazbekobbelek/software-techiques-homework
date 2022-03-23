namespace homework3
{
    public partial class Form1 : Form
    {
        FileInfo loadedFile = null;
        int countdown = 100;
        public Form1()
        {
            InitializeComponent();
        }


        private void miOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string result = dlg.InputText;
                //MessageBox.Show(result);
                DirectoryInfo parentDI = new DirectoryInfo(result);
                listView2.Items.Clear();
                try
                {
                    //getting the name, size and and creationtime of the files
                    foreach (FileInfo fi in parentDI.GetFiles())
                        listView2.Items.Add(new ListViewItem(new string[] { fi.Name, fi.Length.ToString(), fi.CreationTime.ToString(), fi.FullName }));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The process failed: {0}", ex.ToString());
                }
            }
        }

        private void miExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 1)
                return;

            string fullName = listView2.SelectedItems[0].SubItems[3].Text;
            if (fullName != null)
            {
                FileInfo loadedFile = new FileInfo(fullName);
                //setting the name of the selected file to the panel's label
                name_value.Text = loadedFile.Name.ToString();
                //setting the creationtime of the selected file to the panel's label
                created_value.Text = loadedFile.CreationTime.ToString();
                tContent.Text = File.ReadAllText(loadedFile.FullName);
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 1)
                return;

            string fullName = listView2.SelectedItems[0].SubItems[3].Text;
            if (fullName != null)
            {
                loadedFile = new FileInfo(fullName);
                //printig the file to the textbox
                tContent.Text = File.ReadAllText(fullName);
                //starting the timer
                reloadTimer.Start();
                //initalize the counter
                countdown = 100;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            details.Invalidate();
            if (countdown <= 0)
            {
                //reseting the countdown back to 100
                countdown = 100;
                //re-reading the file
                tContent.Text = File.ReadAllText(loadedFile.FullName);
            }
        }

        private void details_Paint(object sender, PaintEventArgs e)
        {
            if (loadedFile != null)
                e.Graphics.FillRectangle(Brushes.Blue, 0, 0, countdown, 10);
        }
    }
}