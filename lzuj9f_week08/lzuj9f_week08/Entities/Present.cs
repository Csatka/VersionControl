using lzuj9f_week08.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lzuj9f_week08.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; private set; }
        public SolidBrush BoxColor { get; private set; }

        public Present(Color rcolor, Color bcolor)
        {
            RibbonColor = new SolidBrush(rcolor);
            BoxColor = new SolidBrush(bcolor);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, Width*2/5, 0, Width / 5, Height);
            g.FillRectangle(RibbonColor, 0, Height * 2 / 5, Width, Height / 5);
        }
    }
}
