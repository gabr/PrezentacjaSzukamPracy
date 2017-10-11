using System.Windows.Forms;

namespace FPaint.Interfaces
{
    interface IDrawUsable
    {
        IMemorable StartDrawing(object sender, MouseEventArgs e);
        IMemorable Drawing(object sender, MouseEventArgs e);
        IMemorable EndDrawing(object sender, MouseEventArgs e);
    }
}
