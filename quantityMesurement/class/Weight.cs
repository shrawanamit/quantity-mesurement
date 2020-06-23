using System;

namespace quantityMesurement
{
    public class Weight:IUnitConvert,IUnitValueAdd
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double ConvertValueInDifferentUnit(Enum.Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Enum.Unit.GRAMS_TO_KILOGRAMS))
                {
                    return value / 1000;
                }
                else if (unit.Equals(Enum.Unit.TONNE_TO_KILOGRAMS))
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
        public double AddTWoUnitValue(double firstUnitValue, double secondUnitValue)
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
