using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Length
    {
        public enum Unit { FEET, INCH ,YARD};

        private readonly double value;
        private readonly Unit unit;
        private const double INCH_TO_YARD=36.0;
        private const double FEET_TO_INCH=12.0;
        private const double INCH_TO_FEET=12.0;
        private const double FEET_TO_YARD=3.0;

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

        public bool Compare(Length that)
        {
            if (this.unit.Equals(that.unit))
            {
                return this.Equals(that); 
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.INCH))
            {
                return this.value.CompareTo(that.value) == 0;
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.FEET))
            {
                return this.value.CompareTo(that.value) == 0;
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.INCH))
            { 
                return this.value * FEET_TO_INCH.CompareTo( that.value) == 0; 
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.INCH))
            {
                return this.value.CompareTo(that.value/INCH_TO_FEET) == 0;
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.YARD))
            {
                return this.value .CompareTo(that.value*FEET_TO_YARD) == 0;
            }
            if (this.unit.Equals(Unit.YARD) && that.unit.Equals(Unit.FEET))
            {
                return this.value * FEET_TO_YARD.CompareTo(that.value ) == 0;
            }
            if (this.unit.Equals(Unit.YARD) && that.unit.Equals(Unit.INCH))
            {
                return this.value * INCH_TO_YARD.CompareTo(that.value) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.YARD))
            {
                return this.value.CompareTo(that.value * INCH_TO_YARD) == 0;
            }
            return false;
        }
    }
}
