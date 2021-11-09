using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FejlesztesiMintak.Abstractions;

namespace FejlesztesiMintak.Entities
{
    class Ball : Toy
    {
 
        protected override void DrawImage( Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

    }
}
