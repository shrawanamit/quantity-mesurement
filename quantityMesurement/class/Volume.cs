using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class Volume:IUnitConvert,IUnitValueAdd
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
                if (unit.Equals(Enum.Unit.GALLON_TO_LITER))
                {
                    return value * 3.78;
                }
                else if (unit.Equals(Enum.Unit.MILILITER_TO_LITER))
                {
                    return value / 1000;
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
