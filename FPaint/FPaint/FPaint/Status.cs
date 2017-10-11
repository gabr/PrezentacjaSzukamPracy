using System.Drawing;
using FPaint.Interfaces;

namespace FPaint
{
    enum BorderAndFillType
	{
	         BorderOnly, FillOnly, BorderAndFill
	}

    class Status
    {
        private IButtonable activeTool;

        public IButtonable ActiveTool
        {
            get
            {
                return activeTool;
            }
            set
            {
                if (activeTool == value)
                    return;
                else if(activeTool != null)
                    activeTool.SwitchActivity();

                value.SwitchActivity();
                activeTool = value;
            }
        }
        public Color FrontColor { get; set; }
        public Color BackColor { get; set; }
        public BorderAndFillType BorderAndFillType { get; set; }
        public int Size { get; set; }
    }
}
