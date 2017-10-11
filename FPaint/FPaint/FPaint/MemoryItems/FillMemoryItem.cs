using System.Drawing;
using FPaint.Interfaces;

namespace FPaint.MemoryItems
{
    class FillMemoryItem : IMemorable
    {
        private Bitmap memoredBitmap;

        public FillMemoryItem()
        {
            this.memoredBitmap = null;
        }

        public FillMemoryItem(Bitmap bitmap)
        {
            this.memoredBitmap = bitmap;
        }

        public void Redraw(System.Drawing.Graphics g)
        {
            if (this.memoredBitmap != null)
                g.DrawImage(this.memoredBitmap, Point.Empty);
        }
    }
}
