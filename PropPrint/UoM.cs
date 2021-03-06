using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropPrint
{
    class UoM
    {
        private string name;
        private double pixelsPerUnit;

        public UoM(string name, double pixelsPerUnit)
        {
            this.name = name;
            this.pixelsPerUnit = pixelsPerUnit;
        }

        public string Name()
        {
            return name;
        }

        public override string ToString()
        {
            return Name();
        }

        

        public int ToPixels(double units)
        {
            int pixels;

            pixels = (int)(units * this.pixelsPerUnit);

            return pixels;

        }

        public double FromPixels(double pixels)
        {
            double units;

            units = pixels / pixelsPerUnit;

            return units;
        }

        public static double ConvertInchToCM(double inch)
        {
            double cm;

            cm = inch * 2.54;

            return cm;
        }
        public static double ConvertCMtoInch(double cm)
        {
            double inch;

            inch = cm * 0.393701;

            return inch;
        }
    }
}
