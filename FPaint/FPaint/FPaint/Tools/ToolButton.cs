using System.Windows.Forms;

namespace FPaint.Tools
{
    class ToolButton
    {
        protected Button button;

        public ToolButton()
        {
            button = new Button();

            button.Size = new System.Drawing.Size(25, 25);
            button.Margin = new Padding(2);
            button.BackColor = System.Drawing.SystemColors.Control;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        protected void SwitchButtonColor()
        {
            if (button.BackColor == System.Drawing.SystemColors.ActiveCaption)
                button.BackColor = System.Drawing.SystemColors.Control;
            else
                button.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
    }
}
