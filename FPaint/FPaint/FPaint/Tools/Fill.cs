using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FPaint.Interfaces;
using FPaint.MemoryItems;

namespace FPaint.Tools
{
    class Fill : ToolButton, IButtonable, IDrawUsable
    {
        private Status status;
        private List<Point> path;

        public Fill(Status status)
        {
            this.status = status;
        }

        public System.Windows.Forms.Button GetButton()
        {
            button.Name = "Fill";
            button.BackgroundImage = ((System.Drawing.Image)(global::FPaint.Properties.Resources.fill));

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
            return new FillMemoryItem();
        }

        public IMemorable Drawing(object sender, MouseEventArgs e)
        {
            return new FillMemoryItem();
        }

        public IMemorable EndDrawing(object sender, MouseEventArgs e)
        {
            path = new List<Point>();
            Color newColor;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    newColor = status.FrontColor;
                    break;
                case MouseButtons.Right:
                    newColor = status.BackColor;
                    break;
                default:
                    newColor = Color.Black;
                    break;
            }

            MyPictureBox pb = sender as MyPictureBox;
            Bitmap bmp = null;
            if (pb != null)
            {
                bmp = pb.Image;
                Color colorToChange = bmp.GetPixel(e.X, e.Y);
                if (colorToChange.ToArgb() != newColor.ToArgb())
                    FloodFill(e.X, e.Y, bmp, colorToChange, newColor);
            }

            return new FillMemoryItem(new Bitmap(bmp));
        }

        private void FloodFill(int x, int y, Bitmap bmp, Color colorToChange, Color newColor)
        {
            Queue<Point> stack = new Queue<Point>();
            stack.Enqueue(new Point(x, y));
            Point tmp;

            while (stack.Count > 0)
            {
                tmp = stack.Dequeue();
                if(IsOnBitmap(tmp, bmp))
                    if (bmp.GetPixel(tmp.X, tmp.Y) == colorToChange)
                    {
                        bmp.SetPixel(tmp.X, tmp.Y, newColor);
                        stack.Enqueue(new Point(tmp.X - 1, tmp.Y));
                        stack.Enqueue(new Point(tmp.X + 1, tmp.Y));
                        stack.Enqueue(new Point(tmp.X, tmp.Y - 1));
                        stack.Enqueue(new Point(tmp.X, tmp.Y + 1));
                    }
            }
        }

        private bool IsOnBitmap(Point tmp, Bitmap bmp)
        {
            if (tmp.X < 0 || tmp.Y < 0) return false;
            if (tmp.X >= bmp.Width || tmp.Y >= bmp.Height) return false;
            return true;
        }
    }
}
