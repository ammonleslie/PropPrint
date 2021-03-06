using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropPrint
{
    class PageFormat
    {
        protected double width, height;
        protected string name;
        protected UoM units;
        protected bool isPortrait;

        public PageFormat(string name, double width, double height, UoM units, bool isPortrait)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.units = units;
            this.isPortrait = isPortrait;
        }

        public string Name()
        {
            return name;
        }


        public double Width()
        {
            return width;
        }

        public double Height()
        {
            return height;
        }

        public bool IsPortrait()
        {
            return isPortrait;
        }

        public UoM Units()
        {
            return units;
        }

        public override string ToString()
        {
            return this.Name();
        }
    }
}
