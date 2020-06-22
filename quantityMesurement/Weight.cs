using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Weight
    {
        public enum Unit
        {
            KILOGRAMS,
            GRAMS,
            GRAMS_TO_KILOGRAMS,
            TONNE_TO_KILOGRAMS
        }

        public double ConvertValueToKiloGrams(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GRAMS_TO_KILOGRAMS))
                {
                    return value / 1000;
                }
                else if (unit.Equals(Unit.TONNE_TO_KILOGRAMS))
                {
                    return value * 1000;
                }

                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
        public double AddTWoUnits(double firstUnitValue, double secondUnitValue)
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
