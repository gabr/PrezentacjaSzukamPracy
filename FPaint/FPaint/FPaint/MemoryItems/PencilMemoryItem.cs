using System.Drawing;
using FPaint.Interfaces;
using System.Collections.Generic;

namespace FPaint.MemoryItems
{
    class PencilMemoryItem : IMemorable
    {
        private Color memoredColor;
        private List<Point> memoredPoints;

        public PencilMemoryItem(List<Point> memoredPoints, Color memoredColor)
        {
            this.memoredColor = memoredColor;
            this.memoredPoints = memoredPoints;
        }

        public void Redraw(System.Drawing.Graphics g)
        {
            Point prev = memoredPoints[0];
            Pen pen = new Pen(memoredColor);

            g.FillRectangle(new SolidBrush(memoredColor), prev.X, prev.Y, 1, 1);

            for (int i = 1; i < memoredPoints.Count; i++)
            {
                g.DrawLine(pen, prev, memoredPoints[i]);
                prev = memoredPoints[i];
            }
        }
    }
}
