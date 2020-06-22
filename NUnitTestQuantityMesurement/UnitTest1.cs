using NUnit.Framework;
using quantityMesurement;
namespace NUnitTestQuantityMesurement
{
    public class Tests
    {
        /// <summary>
        /// 
        /// </summary>
        public Length inch = null;
        public Volume liter = null;
        public Weight killoGrams = null;
        public Temperature celsious = null;
       
       /// <summary>
       /// 
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
            double feetOne =inch.ConvertTheValue( Length.Unit.FEET, 0.0);
            double feetTwo= inch.ConvertTheValue( Length.Unit.FEET, 0.0);
            Assert.AreEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 1 feet and 2 feet is not equals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd2Feet_ShouldReturnNotEquals()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET, 1.0);
            double feetTwo = inch.ConvertTheValue(Length.Unit.FEET, 2.0);
            Assert.AreNotEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 0 feet and null is not equals in length
        /// </summary>
        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET, 0.0);
            Length feetTwo = null;
            Assert.AreNotEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// two objects of differnt reference should return false
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenCheckReference_ShouldReturnFalse()
        {
            Length feetOne = new Length();
            Length feetTwo = new Length();
            bool areEqual = ReferenceEquals(feetOne, feetTwo);
            Assert.IsFalse(areEqual);
        }
        /// <summary>
        /// one objects assign to another should return equal reference 
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenFirstAssignToSecondAndReferenceCheck_ShouldReturnTrue()
        {
            Length feetOne = new Length();
            Length feetTwo = new Length();
            feetTwo = feetOne;
            bool areEqual = ReferenceEquals(feetOne, feetTwo);
            Assert.IsTrue(areEqual);
        }
        /// <summary>
        /// type check of two object  return true 
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET, 3.0);
            double secondFeet = inch.ConvertTheValue(Length.Unit.FEET, 3.0);
            Assert.AreEqual(feetOne.GetType(), secondFeet.GetType());
        }
        /// <summary>
        /// 0 inch and 0 inch is equals in length
        /// </summary>

        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEquals()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH,0.0);
            double inchTwo = inch.ConvertTheValue(Length.Unit.INCH,0.0);
            Assert.AreEqual(inchOne, inchTwo);
        }
        /// <summary>
        /// 0 feet and 1 feet is not eqals in length
        /// </summary>
        [Test]
        public void Given0FeetAnd1Feet_ShouldReturnNotEquals()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.FEET, 0.0);
            double inchTwo = inch.ConvertTheValue(Length.Unit.FEET, 1.0);
            Assert.AreNotEqual(inchOne, inchTwo);
        }
        /// <summary>
        /// 1 feet and 1 inch is not euals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_ShouldReturnNotEquals()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(feetOne, inchOne);
        }
        /// <summary>
        /// 0 feet and 0 inch is equals in length
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 0.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
            Assert.AreEqual(feetOne, inchOne);
        }
        /// <summary>
        /// 1 feet and 1 inch is not equals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenCompared_ShouldReturnNotEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(feetOne, inchOne);
        }
        /// <summary>
        /// 1 feet and 1 feet is equals in length
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double feetTwo = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            Assert.AreEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 1 inch and 1 inch is eqals in length
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double inchTwo = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            Assert.AreEqual(inchOne, inchTwo);
        }
        /// <summary>
        /// 1 feet and 12 inch is eqals in equals length
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 12.0);
            Assert.AreEqual(inchOne, feetOne);
        }
        /// <summary>
        /// 0 yard and 0 yard is equal in length
        /// </summary>
        [Test]
        public void Given0YardAnd0Yard_ShouldReturnEquals()
        {
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD, 0.0);
            double yardTwo = inch.ConvertTheValue(Length.Unit.YARD, 0.0);
            Assert.AreEqual(yardOne, yardTwo);
        }
        /// <summary>
        /// 0 yard and 1 yard is not equal in length
        /// </summary>
        [Test]
        public void Given0YardAnd1Yard_ShouldReturnNotEquals()
        {
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD, 0.0);
            double yardTwo = inch.ConvertTheValue(Length.Unit.YARD, 1.0);
            Assert.AreNotEqual(yardOne, yardTwo);
        }
       
        /// <summary>
        /// 0 feet and 0 yard is eqal in length
        /// </summary>
        [Test]
        public void Given0FeetAnd0Yard_WhenCompared_ShouldReturnNotEqual()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET, 0.0);
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD, 0.0);
            Assert.AreEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 3 feet and 1 yard is eqal in length
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 3.0);
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 1 feet and 1 yard is not equal in lenth 
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreNotEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 1 inch and 1 yard is not eqals in lenth
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreNotEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 1 yard and 36 inch is of equal length
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 36.0);
            Assert.AreEqual(inchOne, yardOne);
        }
        /// <summary>
        /// 36 inch and 1 yard is of equal length
        /// </summary>
        [Test]
        public void Given36InchAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 36.0);
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreEqual(inchOne, yardOne);
        }
        /// <summary>
        /// one yard and three feet is of equal length
        /// </summary>
        [Test]
        public void GivenOneYardAndthreeFeet_WhenCompared_ShouldReturnEqualLength()
        {
            double yardOne = inch.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            double feetOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 3.0);
            Assert.AreEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 2 inch and 5 centimeter is of equal length
        /// </summary>
        [Test]
        public void Given2InchAnd5Centemeter_WhenCompared_ShouldReturnEqualLength()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
            double centimeterOne = inch.ConvertTheValue(Length.Unit.CENTIMETER_TO_INCH, 5.0);
            Assert.AreEqual(inchOne, centimeterOne);
        }
        /// <summary>
        /// addition of 1 inch and 1 inch is 2 inch
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double inchValueTwo = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 2.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
       /// <summary>
       /// addition of 1 feet and 2 inch is 14 inch 
       /// </summary>
        [Test]
        public void Given1FeetAnd2Inch_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchValueTwo = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 14.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        /// <summary>
        /// Addition of 1 feet and 1 feet is 24 inch
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchValueTwo = inch.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 24.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        /// <summary>
        /// addition of 2 inch and 2.5 centimeter is 3.0 inch
        /// </summary>
        [Test]
        public void Given2InchAndCentimeter_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
            double inchValueTwo = inch.ConvertTheValue(Length.Unit.CENTIMETER_TO_INCH, 2.5);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 3.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        /// <summary>
        /// 1 gallon and 3.78 liter is of same volume
        /// </summary>
        [Test]
        public void Given1GallonAndliter_WhenCompared_ShouldReturnEqualvolume()
        {
            double literOne = liter.ConvertValueToLiter(Volume.Unit.GALLON_TO_LITER, 1.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 3.78);
            Assert.AreEqual(literOne, literTwo);
        }
        /// <summary>
        /// 1 liter and 1000 mililiter is of same volume
        /// </summary>
        [Test]
        public void Given1LiterAnd1000Mililiter_WhenCompared_ShouldReturnEqualVolume()
        {
            double literOne = liter.ConvertValueToLiter(Volume.Unit.MILILITER_TO_LITER, 1000.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 1.0);
            Assert.AreEqual(literOne, literTwo);
        }
        /// <summary>
        /// addition of 1 gallon and 3.78 liter is 7.56 liter
        /// </summary>
        [Test]
        public void Given1GallonAnd378iter_WhenAdded_ShouldReturnEqualTotalvolume()
        {
            double literOne = liter.ConvertValueToLiter(Volume.Unit.GALLON_TO_LITER, 1.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 3.78);
            double ActualValue = liter.AddTWoUnitVolume(literOne, literTwo);
            double ExpectedValue = 7.5599999999999996d;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        /// <summary>
        /// Addition of 1000 milimeter and 1 liter is of 2 liter 
        /// </summary>
        [Test]
        public void Given1000MililiterAnd1iter_WhenAdded_ShouldReturnEqualTotalvolume()
        {
            double literOne = liter.ConvertValueToLiter(Volume.Unit.MILILITER_TO_LITER, 1000.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 1.0);
            double ActualValue = liter.AddTWoUnitVolume(literOne, literTwo);
            double ExpectedValue =2.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        /// <summary>
        /// 1 killograms and 1000 grams is of same weight
        /// </summary>
        [Test]
        public void Given1kgAnd1000Grams_WhenCompared_ShouldReturnEqualWeight()
        {
            double weightOne = killoGrams.ConvertValueToKiloGrams(Weight.Unit.GRAMS_TO_KILOGRAMS, 1000.0);
            double weightTwo = killoGrams.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 1.0);
            Assert.AreEqual(weightOne, weightTwo);
        }
        /// <summary>
        /// 1 tonne and 1000 killograms return eqaul weight
        /// </summary>
        [Test]
        public void Given1TonneAnd1000Killograms_WhenCompared_ShouldReturnEqualWeight()
        {
            double weightOne = killoGrams.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 1000.0);
            double weightTwo = killoGrams.ConvertValueToKiloGrams(Weight.Unit.TONNE_TO_KILOGRAMS, 1.0);
            Assert.AreEqual(weightOne, weightTwo);
        }
        /// <summary>
        /// addition of 1 tonne and 1000 grams equal to 1001 kilogram 
        /// </summary>
        [Test]
        public void Given1TonneAnd1000Grams_WhenAdded_ShouldReturnEqualTotalWeight()
        {
            double weightOne = killoGrams.ConvertValueToKiloGrams(Weight.Unit.GRAMS_TO_KILOGRAMS, 1000.0);
            double weightTwo = killoGrams.ConvertValueToKiloGrams(Weight.Unit.TONNE_TO_KILOGRAMS, 1.0);
            double ActualValue = killoGrams.AddTWoUnits(weightOne, weightTwo);
            double ExpectedValue = 1001.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        /// <summary>
        /// 100 celcious equal to 222 fahrenhite
        /// </summary>
        [Test]
        public void Given212FahrenheitAnd100Celcious_WhenCompared_ShouldReturnEqualTemperature()
        {
            double temperatureOne = celsious.ConvertTemperatureToCelsius(Temperature.Unit.FAHRENHEIT_TO_CELSIUS, 222.0);
            double temperatureTwo = celsious.ConvertTemperatureToCelsius(Temperature.Unit.CELSIUS, 100.0);
            Assert.AreEqual(temperatureOne, temperatureTwo);
        }
       
    }
}