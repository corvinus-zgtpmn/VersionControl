using FejlesztesiMintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztesiMintak.Entities
{
    class Present: Toy
    {
        public SolidBrush PresentColorBox { get; private set; }
        public SolidBrush PresentColorRibbon { get; private set; }
        public Present(Color ribbon, Color box)
        {
            PresentColorBox = new SolidBrush( box);
            PresentColorRibbon = new SolidBrush(ribbon);
            protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColorBox, 0, 0, Width, Height);
            g.FillRectangle(PresentColorRibbon, 10, 0, Width, Height);
            g.FillRectangle(PresentColorRibbon, 0, 10, Width, Height);
        }
    }
    }
}
