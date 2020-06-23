using NUnit.Framework;
using quantityMesurement;
namespace NUnitTestQuantityMesurement
{
    public class Tests
    {
        /// <summary>
        /// Instence veriable of class
        /// </summary>
        public Length inch = null;
        public Volume liter = null;
        public Weight killoGrams = null;
        public Temperature celsious = null;
       
       /// <summary>
       /// Object of class
       /// </summary>
        [SetUp]
        public void Setup()
        {
            this.inch = new Length();
            this.liter = new Volume();
            this.celsious = new Temperature();
            this.killoGrams = new Weight();
            
        }

        /// <summary>
        /// 0 feet 0 feet is equals in length
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEquals()
        {
            try
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 0.0);
                double feetTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 0.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 feet and 2 feet is not equals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd2Feet_ShouldReturnNotEquals()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 1.0);
                double feetTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 2.0);
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 0 feet and null is not equals in length
        /// </summary>
        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            try
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 0.0);
                Length feetTwo = null;
                Assert.AreNotEqual(feetOne, feetTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
           
        }
        /// <summary>
        /// Two objects of differnt reference should return false
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            try
            {
                Length feetOne = new Length();
                Length feetTwo = new Length();
                bool areEqual = ReferenceEquals(feetOne, feetTwo);
                Assert.IsFalse(areEqual);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// One objects assign to another should return equal reference 
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            try
            {
                Length feetOne = new Length();
                Length feetTwo = new Length();
                feetTwo = feetOne;
                bool areEqual = ReferenceEquals(feetOne, feetTwo);
                Assert.IsTrue(areEqual);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Type check of two object  return true 
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            try
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 3.0);
                double secondFeet = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 3.0);
                Assert.AreEqual(feetOne.GetType(), secondFeet.GetType());
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 0 inch and 0 inch is equals in length
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEquals()
        {
            try 
            {
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 0.0);
                double inchTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 0.0);
                Assert.AreEqual(inchOne, inchTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 0 feet and 1 feet is not eqals in length
        /// </summary>
        [Test]
        public void Given0FeetAnd1Feet_ShouldReturnNotEquals()
        {
            try 
            {
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 0.0);
                double inchTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 1.0);
                Assert.AreNotEqual(inchOne, inchTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 feet and 1 inch is not euals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_ShouldReturnNotEquals()
        {
            try
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                Assert.AreNotEqual(feetOne, inchOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 0 feet and 0 inch is equals in length
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqualLength()
        {
            try
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 0.0);
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 0.0);
                Assert.AreEqual(feetOne, inchOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 feet and 1 inch is not equals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenCompared_ShouldReturnNotEqualLength()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                Assert.AreNotEqual(feetOne, inchOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 feet and 1 feet is equals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCompared_ShouldReturnEqualLength()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double feetTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                Assert.AreEqual(feetOne, feetTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 inch and 1 inch is eqals in length
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenCompared_ShouldReturnEqualLength()
        {
            try
            {
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                double inchTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                Assert.AreEqual(inchOne, inchTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 feet and 12 inch is eqals in equals length
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenCompared_ShouldReturnEqualLength()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 12.0);
                Assert.AreEqual(inchOne, feetOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 0 yard and 0 yard is equal in length
        /// </summary>
        [Test]
        public void Given0YardAnd0Yard_ShouldReturnEquals()
        {
            try
            {
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD, 0.0);
                double yardTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD, 0.0);
                Assert.AreEqual(yardOne, yardTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 0 yard and 1 yard is not equal in length
        /// </summary>
        [Test]
        public void Given0YardAnd1Yard_ShouldReturnNotEquals()
        {
            try 
            {
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD, 0.0);
                double yardTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD, 1.0);
                Assert.AreNotEqual(yardOne, yardTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
       
        /// <summary>
        /// 0 feet and 0 yard is eqal in length
        /// </summary>
        [Test]
        public void Given0FeetAnd0Yard_WhenCompared_ShouldReturnNotEqual()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET, 0.0);
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD, 0.0);
                Assert.AreEqual(feetOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 3 feet and 1 yard is eqal in length
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            try
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 3.0);
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD_TO_Inch, 1.0);
                Assert.AreEqual(feetOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 feet and 1 yard is not equal in lenth 
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD_TO_Inch, 1.0);
                Assert.AreNotEqual(feetOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 inch and 1 yard is not eqals in lenth
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            try 
            {
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD_TO_Inch, 1.0);
                Assert.AreNotEqual(feetOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
        /// <summary>
        /// 1 yard and 36 inch is of equal length
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_WhenCompared_ShouldReturnEqualLength()
        {
            try
            {
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD_TO_Inch, 1.0);
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 36.0);
                Assert.AreEqual(inchOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 36 inch and 1 yard is of equal length
        /// </summary>
        [Test]
        public void Given36InchAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            try 
            {
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 36.0);
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD_TO_Inch, 1.0);
                Assert.AreEqual(inchOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// one yard and three feet is of equal length
        /// </summary>
        [Test]
        public void GivenOneYardAndthreeFeet_WhenCompared_ShouldReturnEqualLength()
        {
            try 
            {
                double yardOne = inch.ConvertValueInDifferentUnit(Enum.Unit.YARD_TO_Inch, 1.0);
                double feetOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 3.0);
                Assert.AreEqual(feetOne, yardOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 2 inch and 5 centimeter is of equal length
        /// </summary>
        [Test]
        public void Given2InchAnd5Centemeter_WhenCompared_ShouldReturnEqualLength()
        {
            try
            {
                double inchOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 2.0);
                double centimeterOne = inch.ConvertValueInDifferentUnit(Enum.Unit.CENTIMETER_TO_INCH, 5.0);
                Assert.AreEqual(inchOne, centimeterOne);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// addition of 1 inch and 1 inch is 2 inch
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenAdded_ShouldReturnTotalSum()
        {
            try
            {
                double inchValueOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                double inchValueTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 1.0);
                double ActualValue = inch.AddTWoUnitValue(inchValueOne, inchValueTwo);
                double ExpectedValue = 2.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

       /// <summary>
       /// addition of 1 feet and 2 inch is 14 inch 
       /// </summary>
        [Test]
        public void Given1FeetAnd2Inch_WhenAdded_ShouldReturnTotalSum()
        {
            try
            {
                double inchValueOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double inchValueTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 2.0);
                double ActualValue = inch.AddTWoUnitValue(inchValueOne, inchValueTwo);
                double ExpectedValue = 14.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Addition of 1 feet and 1 feet is 24 inch
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ShouldReturnTotalSum()
        {
            try 
            {
                double inchValueOne = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double inchValueTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.FEET_TO_INCH, 1.0);
                double ActualValue = inch.AddTWoUnitValue(inchValueOne, inchValueTwo);
                double ExpectedValue = 24.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Addition of 2 inch and 2.5 centimeter is 3.0 inch
        /// </summary>
        [Test]
        public void Given2InchAndCentimeter_WhenAdded_ShouldReturnTotalSum()
        {
            try
            {
                double inchValueOne = inch.ConvertValueInDifferentUnit(Enum.Unit.INCH, 2.0);
                double inchValueTwo = inch.ConvertValueInDifferentUnit(Enum.Unit.CENTIMETER_TO_INCH, 2.5);
                double ActualValue = inch.AddTWoUnitValue(inchValueOne, inchValueTwo);
                double ExpectedValue = 3.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 gallon and 3.78 liter is of same volume
        /// </summary>
        [Test]
        public void Given1GallonAndliter_WhenCompared_ShouldReturnEqualvolume()
        {
            try {
                double literOne = liter.ConvertValueInDifferentUnit(Enum.Unit.GALLON_TO_LITER, 1.0);
                double literTwo = liter.ConvertValueInDifferentUnit(Enum.Unit.LITER, 3.78);
                Assert.AreEqual(literOne, literTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 liter and 1000 mililiter is of same volume
        /// </summary>
        [Test]
        public void Given1LiterAnd1000Mililiter_WhenCompared_ShouldReturnEqualVolume()
        {
            try
            {
                double literOne = liter.ConvertValueInDifferentUnit(Enum.Unit.MILILITER_TO_LITER, 1000.0);
                double literTwo = liter.ConvertValueInDifferentUnit(Enum.Unit.LITER, 1.0);
                Assert.AreEqual(literOne, literTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Addition of 1 gallon and 3.78 liter is 7.56 liter
        /// </summary>
        [Test]
        public void Given1GallonAnd378iter_WhenAdded_ShouldReturnEqualTotalvolume()
        {
            try {
                double literOne = liter.ConvertValueInDifferentUnit(Enum.Unit.GALLON_TO_LITER, 1.0);
                double literTwo = liter.ConvertValueInDifferentUnit(Enum.Unit.LITER, 3.78);
                double ActualValue = liter.AddTWoUnitValue(literOne, literTwo);
                double ExpectedValue = 7.5599999999999996d;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// Addition of 1000 milimeter and 1 liter is of 2 liter 
        /// </summary>
        [Test]
        public void Given1000MililiterAnd1iter_WhenAdded_ShouldReturnEqualTotalvolume()
        {
            try {
                double literOne = liter.ConvertValueInDifferentUnit(Enum.Unit.MILILITER_TO_LITER, 1000.0);
                double literTwo = liter.ConvertValueInDifferentUnit(Enum.Unit.LITER, 1.0);
                double ActualValue = liter.AddTWoUnitValue(literOne, literTwo);
                double ExpectedValue = 2.0;
                Assert.AreEqual(ExpectedValue, ActualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 killograms and 1000 grams is of same weight
        /// </summary>
        [Test]
        public void Given1kgAnd1000Grams_WhenCompared_ShouldReturnEqualWeight()
        {
            try
            {
                double weightOne = this.killoGrams.ConvertValueInDifferentUnit(Enum.Unit.GRAMS_TO_KILOGRAMS, 1000.0);
                double weightTwo = this.killoGrams.ConvertValueInDifferentUnit(Enum.Unit.KILOGRAMS, 1.0);
                Assert.AreEqual(weightOne, weightTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 1 ton and 1000 killograms return eqaul weight
        /// </summary>
        [Test]
        public void Given1TonneAnd1000Killograms_WhenCompared_ShouldReturnEqualWeight()
        {
            try
            {
                double weightOne = this.killoGrams.ConvertValueInDifferentUnit(Enum.Unit.KILOGRAMS, 1000.0);
                double weightTwo = this.killoGrams.ConvertValueInDifferentUnit(Enum.Unit.TONNE_TO_KILOGRAMS, 1.0);
                Assert.AreEqual(weightOne, weightTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// addition of 1 ton and 1000 grams equal to 1001 kilogram 
        /// </summary>
        [Test]
        public void Given1TonAnd1000Grams_WhenAdded_ShouldReturnEqualTotalWeight()
        {
            try 
            {
                double weightOne = this.killoGrams.ConvertValueInDifferentUnit(Enum.Unit.GRAMS_TO_KILOGRAMS, 1000.0);
                double weightTwo = this.killoGrams.ConvertValueInDifferentUnit(Enum.Unit.TONNE_TO_KILOGRAMS, 1.0);
                double actualValue = this.killoGrams.AddTWoUnitValue(weightOne, weightTwo);
                double expectedValue = 1001.0;
                Assert.AreEqual(expectedValue, actualValue);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        /// <summary>
        /// 100 celsius equal to 222 fahrenheit
        /// </summary>
        [Test]
        public void Given212FahrenheitAnd100Celsius_WhenCompared_ShouldReturnEqualTemperature()
        {
            try 
            {
                double temperatureOne = this.celsious.ConvertValueInDifferentUnit(Enum.Unit.FAHRENHEIT_TO_CELSIUS, 212.0);
                double temperatureTwo = this.celsious.ConvertValueInDifferentUnit(Enum.Unit.CELSIUS, 100.0);
                Assert.AreEqual(temperatureOne, temperatureTwo);
            }
            catch (QuantityMesurementException e)
            {
                throw new QuantityMesurementException(QuantityMesurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}