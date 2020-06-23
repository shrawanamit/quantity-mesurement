using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    /// <summary>
    /// 
    /// </summary>
    interface IUnitConvert
    {
        double ConvertValueInDifferentUnit(Enum.Unit unit, double value);
    }
}
