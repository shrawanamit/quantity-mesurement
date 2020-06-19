using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Length
    {
        public enum Unit { FEET, INCH };

        private readonly double value;
        private readonly Unit unit;

        public Length(double value, Unit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public override bool Equals(object obj)
        {
            return obj is Length length &&
                   value == length.value &&
                   unit == length.unit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value, unit);
        }
    }
}
