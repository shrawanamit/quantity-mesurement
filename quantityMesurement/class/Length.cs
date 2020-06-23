using System;
namespace quantityMesurement
{
    public class Length:IUnitConvert,IUnitValueAdd
    {
        /// <summary>
        /// convert the any unit length into inch
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns>inch</returns>
        public double ConvertValueInDifferentUnit(Enum.Unit unit,double value)
        {
            try
            {
                if (unit.Equals(Enum.Unit.FEET_TO_INCH))
                {
                    return value * 12.0;
                }
                else if (unit.Equals(Enum.Unit.YARD_TO_Inch))
                {
                    return value * 36.0;
                }
                else if (unit.Equals(Enum.Unit.CENTIMETER_TO_INCH))
                {
                    return value / 2.5;
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
        /// Add two unit value
        /// </summary>
        /// <param name="firstUnitValue"></param>
        /// <param name="secondUnitValue"></param>
        /// <returns>Addition of two unit</returns>
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
