using ajandek.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajandek.Entities
{
    public class PresntFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Present(BoxColor);
        }
        public Color BoxColor { get; set; }
    }
}
