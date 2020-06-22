using System;
namespace quantityMesurement
{
    public class Length
    {
        // creating enum for feet and inch
        public enum Unit 
        {
            FEET,
            INCH,
            YARD,
            FEET_TO_INCH,
            YARD_TO_Inch
        };
        /// <summary>
        /// default constructer
        /// </summary>
        public Length()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double ConvertTheValue(Unit unit,double value)
        {
            try
            {
                if (unit.Equals(Unit.FEET_TO_INCH))
                {
                    return value * 12.0;
                }
                else if (unit.Equals(Unit.YARD_TO_Inch))
                {
                    return value * 36.0;
                }
                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}
