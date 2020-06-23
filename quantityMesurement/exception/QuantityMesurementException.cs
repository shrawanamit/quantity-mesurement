using System;
using System.Collections.Generic;
using System.Text;

namespace quantityMesurement
{
    public class QuantityMesurementException : Exception
    {
        /// <summary>
        /// Enum is Used to define Enumerated Data types
        /// </summary>
        public enum ExceptionType
        {
            InvalidValue
        }

        public ExceptionType type { get; set; }

        public QuantityMesurementException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
