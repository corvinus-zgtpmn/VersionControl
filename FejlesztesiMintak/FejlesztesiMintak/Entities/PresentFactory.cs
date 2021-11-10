using FejlesztesiMintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztesiMintak.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color PresentColorBox { get; set; }
        public Color PresentColorRibbon { get; set; }
        public Toy CreateNew()
        {
            return new Present(PresentColorBox, PresentColorRibbon);
        }
    }
}
