using System.Drawing;
using FPaint.Interfaces;
using System.Collections.Generic;

namespace FPaint.MemoryItems
{
    class RubberMemoryItem : IMemorable
    {
        private float rubberSize;
        private Color memoredColor;
        private List<Point> memoredPoints;

        public RubberMemoryItem(List<Point> memoredPoints, Color memoredColor, float rubberSize)
        {
            this.memoredColor = memoredColor;
            this.memoredPoints = memoredPoints;
            this.rubberSize = rubberSize;
        }

        public void Redraw(System.Drawing.Graphics g)
        {
            Point prev = memoredPoints[0];
            Pen pen = new Pen(memoredColor, rubberSize);

            g.FillRectangle(new SolidBrush(memoredColor),
                prev.X - rubberSize / 2, prev.Y - rubberSize / 2,
                rubberSize, rubberSize);

            for (int i = 1; i < memoredPoints.Count; i++)
            {
                g.DrawLine(pen, prev, memoredPoints[i]);
                prev = memoredPoints[i];
                g.FillRectangle(new SolidBrush(memoredColor),
                    prev.X - rubberSize / 2, prev.Y - rubberSize / 2,
                    rubberSize, rubberSize);
            }
        }
    }
}
