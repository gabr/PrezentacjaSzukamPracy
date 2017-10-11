using System.Drawing;
using System.Windows.Forms;
using FPaint.Interfaces;
using FPaint.MemoryItems;

namespace FPaint.Tools
{
    class Circle : ToolButton, IButtonable, IDrawUsable
    {
        private Status status;
        private Point startPoint;

        // memory items
        private int memoredSize;
        private Color memoredFillColor;
        private Color memoredBorderColor;
        private Rectangle memoredRectangle;
        private BorderAndFillType memoredBorderAndFillType;

        public Circle(Status status)
        {
            this.status = status;
        }

        public System.Windows.Forms.Button GetButton()
        {
            button.Name = "Cirlce";
            button.BackgroundImage = ((System.Drawing.Image)(global::FPaint.Properties.Resources.circle));

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
            memoredRectangle = new Rectangle();
            startPoint = new Point(e.X, e.Y);

            memoredRectangle.X = e.X;
            memoredRectangle.Y = e.Y;
            memoredBorderAndFillType = status.BorderAndFillType;
            memoredSize = status.Size;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    memoredBorderColor = status.FrontColor;
                    memoredFillColor = status.BackColor;
                    break;
                case MouseButtons.Right:
                    memoredFillColor = status.FrontColor;
                    memoredBorderColor = status.BackColor;
                    break;
                default:
                    memoredFillColor = Color.Black;
                    memoredBorderColor = Color.Black;
                    break;
            }

            return new CircleMemoryItem(memoredRectangle, memoredBorderColor, memoredFillColor,
                memoredBorderAndFillType, memoredSize);
        }

        public IMemorable Drawing(object sender, MouseEventArgs e)
        {
            if (startPoint.X < e.X)
                memoredRectangle.Width = e.X - startPoint.X;
            else
            {
                memoredRectangle.X = e.X;
                memoredRectangle.Width = startPoint.X - e.X;
            }

            if (startPoint.Y < e.Y)
                memoredRectangle.Height = e.Y - startPoint.Y;
            else
            {
                memoredRectangle.Y = e.Y;
                memoredRectangle.Height = startPoint.Y - e.Y;
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                int max = memoredRectangle.Height > memoredRectangle.Width ?
                    memoredRectangle.Height : memoredRectangle.Width;

                memoredRectangle.Height = memoredRectangle.Width = max;
            }

            return new CircleMemoryItem(memoredRectangle, memoredBorderColor, memoredFillColor,
                memoredBorderAndFillType, memoredSize);
        }

        public IMemorable EndDrawing(object sender, MouseEventArgs e)
        {
            return new CircleMemoryItem(memoredRectangle, memoredBorderColor, memoredFillColor,
                memoredBorderAndFillType, memoredSize);
        }
    }
}
