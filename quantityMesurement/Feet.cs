using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Feet
    {
        private readonly double value;

        public Feet(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Feet feet &&
                   value == feet.value;
        }
    }
}
