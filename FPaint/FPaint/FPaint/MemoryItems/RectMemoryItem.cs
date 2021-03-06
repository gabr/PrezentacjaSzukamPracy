﻿using System.Drawing;
using FPaint.Interfaces;

namespace FPaint.MemoryItems
{
    class RectMemoryItem : IMemorable
    {
        private int memoredSize;
        private Color memoredFillColor;
        private Color memoredBorderColor;
        private Rectangle memoredRectangle;
        private BorderAndFillType memoredBorderAndFillType;

        public RectMemoryItem(Rectangle memoredRectangle, Color memoredBorderColor,
            Color memoredFillColor, BorderAndFillType memoredBorderAndFillType, int memoredSize)
        {
            this.memoredRectangle = memoredRectangle;
            this.memoredBorderColor = memoredBorderColor;
            this.memoredFillColor = memoredFillColor;
            this.memoredBorderAndFillType = memoredBorderAndFillType;
            this.memoredSize = memoredSize;
        }

        public void Redraw(Graphics g)
        {

            switch (memoredBorderAndFillType)
            {
                case BorderAndFillType.BorderOnly:
                    g.DrawRectangle(new Pen(memoredBorderColor, memoredSize), memoredRectangle);
                    break;
                case BorderAndFillType.FillOnly:
                    g.FillRectangle(new SolidBrush(memoredFillColor), memoredRectangle);
                    break;
                case BorderAndFillType.BorderAndFill:
                    g.DrawRectangle(new Pen(memoredBorderColor, memoredSize+1), memoredRectangle);
                    g.FillRectangle(new SolidBrush(memoredFillColor), memoredRectangle);
                    break;
                default:
                    break;
            }
            
        }
    }
}
