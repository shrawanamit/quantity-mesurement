using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Weight
    {
        /// <summary>
        /// 
        /// </summary>
        public enum Unit
        {
            KILOGRAMS,
            GRAMS,
            GRAMS_TO_KILOGRAMS,
            TONNE_TO_KILOGRAMS
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstUnitValue"></param>
        /// <param name="secondUnitValue"></param>
        /// <returns></returns>
        public double AddTWoUnits(double firstUnitValue, double secondUnitValue)
        {
            try
            {
                return firstUnitValue + secondUnitValue;
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
