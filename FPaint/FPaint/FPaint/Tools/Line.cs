using System.Drawing;
using System.Windows.Forms;
using FPaint.Interfaces;
using FPaint.MemoryItems;

namespace FPaint.Tools
{
    class Line : ToolButton, IButtonable, IDrawUsable
    {
        private Status status;

        // memory items
        private int memoredSize;
        private Color memoredColor;
        private Point memoredEndPoint;
        private Point memoredStartPoint;

        public Line(Status status)
        {
            this.status = status;
        }

        public System.Windows.Forms.Button GetButton()
        {
            button.Name = "Line";
            button.BackgroundImage = ((System.Drawing.Image)(global::FPaint.Properties.Resources.line));

            // events
            button.Click += new System.EventHandler(this.Button_Click);

            return button;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            status.ActiveTool = this;
        }

        public void SwitchActivity()
        {
            this.SwitchButtonColor();
        }

        public IMemorable StartDrawing(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    memoredColor = status.FrontColor;
                    break;
                case MouseButtons.Right:
                    memoredColor = status.BackColor;
                    break;
                default:
                    memoredColor = Color.Black;
                    break;
            }

            memoredStartPoint = new Point(e.X, e.Y);
            memoredEndPoint = new Point(e.X, e.Y);
            memoredSize = status.Size;

            return new LineMemoryItem(memoredStartPoint, memoredEndPoint, memoredColor, memoredSize);
        }

        public IMemorable Drawing(object sender, MouseEventArgs e)
        {
            memoredEndPoint = new Point(e.X, e.Y);

            if (Control.ModifierKeys == Keys.Control)
            {
                int width, height;

                if (memoredStartPoint.X < e.X)
                    width = e.X - memoredStartPoint.X;
                else
                    width = memoredStartPoint.X - e.X;

                if (memoredStartPoint.Y < e.Y)
                    height = e.Y - memoredStartPoint.Y;
                else
                    height = memoredStartPoint.Y - e.Y;

                if (height <= width) memoredEndPoint.Y = memoredStartPoint.Y;
                else memoredEndPoint.X = memoredStartPoint.X;

            }

            return new LineMemoryItem(memoredStartPoint, memoredEndPoint, memoredColor, memoredSize);
        }

        public IMemorable EndDrawing(object sender, MouseEventArgs e)
        {
            return Drawing(sender, e);
        }
    }
}
