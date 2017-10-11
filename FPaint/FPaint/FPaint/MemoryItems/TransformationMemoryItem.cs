using System.Drawing;
using FPaint.Interfaces;

namespace FPaint.MemoryItems
{
    class TransformationMemoryItem : ImageMemoryItem, IMemorable
    {
        private Size size;

        public Size Size
        {
            get
            {
                return size;
            }
        }

        public TransformationMemoryItem(Bitmap bmp, Size size) : base(bmp, Point.Empty)
        {
            this.size = size;
        }
    }
}
