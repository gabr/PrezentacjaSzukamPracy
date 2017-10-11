using System.Drawing;
using FPaint.Interfaces;

namespace FPaint.MemoryItems
{
    class ImageMemoryItem : IMemorable
    {
        private Bitmap image;
        private Point position;

        public ImageMemoryItem(Bitmap bmp, Point p)
        {
            image = bmp;
            position = p;
        }

        public void Redraw(Graphics g)
        {
            g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), position.X, position.Y,
                image.Width, image.Height, GraphicsUnit.Pixel);
        }
    }
}
