using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Signals
{
    partial class GraphicsSignalView : UserControl, IView
    {
        /// <summary>
        /// Backing field for the ViewNumber property.
        /// </summary>
        private int viewNumber;
        // pixels in one second
        float pixelPerSec = 60.0f;
        // amount of pixels per unit of value
        float pixelPerValue = 4.0f;
        // zoom coefficient
        double zoom = 1;

        /// <summary>
        /// The ordinal number of the view.
        /// </summary>
        public int ViewNumber
        {
            get { return viewNumber; }
            set { viewNumber = value; }
        }

        public GraphicsSignalView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The document the view is attached to.
        /// TODO: modify its type to the type of the concrete document.
        /// </summary>
        private SignalDocument document;

        public GraphicsSignalView(SignalDocument document)
        {
            InitializeComponent();
            this.document = document;
        }

        /// <summary>
        /// Implements the Update method of the IView interface.
        /// </summary>
        public void Update()
        {
            Invalidate();
        }

        public Document GetDocument()
        {
            return document;
        }

        /// <summary>
        /// Overrides the UserControl.OnPaint. Implement the drawing here.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Drawing axes
            Pen pen = new Pen(Color.Red, 2);
            pen.DashStyle = DashStyle.Solid;
            pen.EndCap = LineCap.ArrowAnchor;
            int x = ClientSize.Width;
            int y = ClientSize.Height;
            e.Graphics.DrawLine(pen, 1, y, 1, 0);
            e.Graphics.DrawLine(pen, 0, y / 2, x, y / 2);

            bool isFirstPoint = true;

            // Changes in coordinates
            float actualX = 0.0f;
            float actualY = 0.0f;
            float prevX = 0.0f;
            float prevY = 0.0f;

            SignalValue prevSignalValue = null;

            foreach (SignalValue signalValue in document.SignalValues)
            {
                if (!isFirstPoint)
                {
                    // To calculate the coordinate we divide the difference between previous signal and current by the pixelPerSec
                    // then we multiply it by the zoom coefficient
                    actualX += (float)(((signalValue.TimeStamp.Ticks - prevSignalValue.TimeStamp.Ticks) / 10000000.0f * pixelPerSec) * zoom);
                    actualY = (float)(y / 2 - ((signalValue.Value * pixelPerValue)) * zoom);
                    // Drawing the line
                    e.Graphics.DrawLine(new Pen(Color.Black), prevX, prevY, actualX, actualY);
                }
                else
                {
                    isFirstPoint = false;
                    actualY = actualY = (float)(y / 2 - ((signalValue.Value * pixelPerValue)) * zoom);
                }
                e.Graphics.FillRectangle(Brushes.Black, actualX - 1, actualY - 1, 3, 3);

                prevSignalValue = signalValue;
                prevX = actualX;
                prevY = actualY;
            }
        }

        // Zooming in
        private void plus_b_Click(object sender, EventArgs e)
        {
            zoom *= 1.2;
            Invalidate();
        }

        // Zooming out

        private void minus_b_Click(object sender, EventArgs e)
        {
            zoom /= 1.2;
            Invalidate();
        }
    }
}
