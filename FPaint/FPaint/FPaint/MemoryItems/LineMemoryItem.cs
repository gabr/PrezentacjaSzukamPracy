using System.Drawing;
using FPaint.Interfaces;

namespace FPaint.MemoryItems
{
    class LineMemoryItem : IMemorable
    {
        private int memoredSize;
        private Color memoredColor;
        private Point memoredEndPoint;
        private Point memoredStartPoint;

        public LineMemoryItem(Point memoredStartPoint, Point memoredEndPoint, Color memoredColor,
            int memoredSize)
        {
            this.memoredStartPoint = memoredStartPoint;
            this.memoredEndPoint = memoredEndPoint;
            this.memoredColor = memoredColor;
            this.memoredSize = memoredSize;
        }

        public void Redraw(System.Drawing.Graphics g)
        {
            g.DrawLine(new Pen(memoredColor, memoredSize), memoredStartPoint, memoredEndPoint);
        }
    }
}
