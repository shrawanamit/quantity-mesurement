using System;

namespace quantityMesurement
{
    public class Temperature:IUnitConvert
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double ConvertValueInDifferentUnit(Enum.Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Enum.Unit.FAHRENHEIT_TO_CELSIUS))
                {
                    return (value / 212)*100;
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
    }
}
