using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Inch
    {
        private readonly double value;

        public Inch(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Inch inch &&
                   value == inch.value;
        }
    }
}
