using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Volume
    {
        public enum Unit
        {
            GALLON,
            LITER,
            GALLON_TO_LITER,
            MILILITER_TO_LITER
        }

        public double ConvertValueToLiter(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GALLON_TO_LITER))
                {
                    return value * 3.78;
                }
                else if (unit.Equals(Unit.MILILITER_TO_LITER))
                {
                    return value / 1000;
                }

                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }

        }
        public double AddTWoUnitVolume(double firstUnitValue, double secondUnitValue)
        {
            try
            {
                return firstUnitValue + secondUnitValue;
            }
            catch (Exception e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }

        }
    }
}
