using System;
using System.Drawing;
using FPaint.Interfaces;

namespace FPaint.MemoryItems
{
    class ResizeMemoryItem : IMemorable
    {
        private Size size;

        public Size Size
        {
            get
            {
                return size;
            }
        }

        public ResizeMemoryItem(Size size)
        {
            this.size = size;
        }

        public void Redraw(System.Drawing.Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
