using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FPaint.Interfaces;
using FPaint.MemoryItems;

namespace FPaint.Tools
{
    class Pencil : ToolButton, IButtonable, IDrawUsable
    {
        private Status status;
        private Point endPoint;
        private Point startPoint;

        // memory items
        private Color memoredColor;
        private List<Point> memoredPoints;

        public Pencil(Status status)
        {
            this.status = status;
        }

        public System.Windows.Forms.Button GetButton()
        {
            button.Name = "Pencil";
            button.BackgroundImage = ((System.Drawing.Image)(global::FPaint.Properties.Resources.pen));

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
            SolidBrush color = null;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    color = new SolidBrush(status.FrontColor);
                    break;
                case MouseButtons.Right:
                    color = new SolidBrush(status.BackColor);
                    break;
                default:
                    color = new SolidBrush(Color.Black);
                    break;
            }

            startPoint.X = e.X;
            startPoint.Y = e.Y;

            memoredPoints = new List<Point>();
            memoredPoints.Add(startPoint);
            memoredColor = color.Color;

            return new PencilMemoryItem(memoredPoints, memoredColor);
        }

        public IMemorable Drawing(object sender, MouseEventArgs e)
        {
            endPoint.X = e.X;
            endPoint.Y = e.Y;

            startPoint = endPoint;
            memoredPoints.Add(startPoint);

            return new PencilMemoryItem(memoredPoints, memoredColor);
        }

        public IMemorable EndDrawing(object sender, MouseEventArgs e)
        {
            endPoint.X = e.X;
            endPoint.Y = e.Y;

            memoredPoints.Add(endPoint);
            startPoint = endPoint = Point.Empty;

            return new PencilMemoryItem(memoredPoints, memoredColor);
        }
    }
}
