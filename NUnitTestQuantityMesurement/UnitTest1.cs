using NUnit.Framework;
using quantityMesurement;
namespace NUnitTestQuantityMesurement
{
    public class Tests
    {
        public Length yard = null;
        public Length feet = null;
        public Length inch = null;
        public Length centimeter = null;
        public Volume liter = null;
        public Volume gallon = null;
        public Volume miliLiter = null;
        public Weight grams = null;
        public Weight killograms = null;
        public Weight tones = null;

        [SetUp]
        public void Setup()
        {
            this.yard = new Length();
            this.feet = new Length();
            this.inch = new Length();
            this.centimeter = new Length();
            this.liter = new Volume();
            this.miliLiter = new Volume();
            this.gallon = new Volume();
            this.grams = new Weight();
            this.killograms = new Weight();
            this.tones = new Weight();
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEquals()
        {
            double feetOne =feet.ConvertTheValue( Length.Unit.FEET, 0.0);
            double feetTwo= feet.ConvertTheValue( Length.Unit.FEET, 0.0);
            Assert.AreEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1FeetAnd2Feet_ShouldReturnNotEquals()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET, 1.0);
            double feetTwo = feet.ConvertTheValue(Length.Unit.FEET, 2.0);
            Assert.AreNotEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0FeetAndNull_ShouldReturnsNotEqual()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET, 0.0);
            Length feetTwo = null;
            Assert.AreNotEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Test]
        public void GivenTwoObjects_WhenTypeChecked_ShouldReturnEqual()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET, 3.0);
            double secondFeet = feet.ConvertTheValue(Length.Unit.FEET, 3.0);
            Assert.AreEqual(feetOne.GetType(), secondFeet.GetType());
        }
        /// <summary>
        /// 
        /// </summary>

        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEquals()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH,0.0);
            double inchTwo = inch.ConvertTheValue(Length.Unit.INCH,0.0);
            Assert.AreEqual(inchOne, inchTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0FeetAnd1Feet_ShouldReturnNotEquals()
        {
            double inchOne = feet.ConvertTheValue(Length.Unit.FEET, 0.0);
            double inchTwo = inch.ConvertTheValue(Length.Unit.FEET, 1.0);
            Assert.AreNotEqual(inchOne, inchTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_ShouldReturnNotEquals()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(feetOne, inchOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 0.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 0.0);
            Assert.AreEqual(feetOne, inchOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenCompared_ShouldReturnNotEqualLength()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(feetOne, inchOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double feetTwo = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            Assert.AreEqual(feetOne, feetTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double inchTwo = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            Assert.AreEqual(inchOne, inchTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 12.0);
            Assert.AreEqual(inchOne, feetOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0YardAnd0Yard_ShouldReturnEquals()
        {
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD, 0.0);
            double yardTwo = yard.ConvertTheValue(Length.Unit.YARD, 0.0);
            Assert.AreEqual(yardOne, yardTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0YardAnd1Yard_ShouldReturnNotEquals()
        {
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD, 0.0);
            double yardTwo = yard.ConvertTheValue(Length.Unit.YARD, 1.0);
            Assert.AreNotEqual(yardOne, yardTwo);
        }
       
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given0FeetAnd0Yard_WhenCompared_ShouldReturnNotEqual()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET, 0.0);
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD, 0.0);
            Assert.AreEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 3.0);
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreNotEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            double feetOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreNotEqual(feetOne, yardOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_WhenCompared_ShouldReturnEqualLength()
        {
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 36.0);
            Assert.AreEqual(inchOne, yardOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given36InchAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 36.0);
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            Assert.AreEqual(inchOne, yardOne);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void GivenOneYardAndthreeFeet_WhenCompared_ShouldReturnEqualLength()
        {
            double yardOne = yard.ConvertTheValue(Length.Unit.YARD_TO_Inch, 1.0);
            double feetOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 3.0);
            Assert.AreEqual(feetOne, yardOne);
        }
        [Test]
        public void Given2InchAnd5Centemeter_WhenCompared_ShouldReturnEqualLength()
        {
            double inchOne = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
            double centimeterOne = centimeter.ConvertTheValue(Length.Unit.CENTIMETER_TO_INCH, 5.0);
            Assert.AreEqual(inchOne, centimeterOne);
        }
        [Test]
        public void Given1InchAnd1Inch_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double inchValueTwo = inch.ConvertTheValue(Length.Unit.INCH, 1.0);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 2.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
       
        [Test]
        public void Given1FeetAnd2Inch_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchValueTwo = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 14.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double inchValueTwo = feet.ConvertTheValue(Length.Unit.FEET_TO_INCH, 1.0);
            double ActualValue = feet.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 24.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [Test]
        public void Given2InchAndCentimeter_WhenAdded_ShouldReturnTotalSum()
        {
            double inchValueOne = inch.ConvertTheValue(Length.Unit.INCH, 2.0);
            double inchValueTwo = centimeter.ConvertTheValue(Length.Unit.CENTIMETER_TO_INCH, 2.5);
            double ActualValue = inch.AddTWoUnitLengths(inchValueOne, inchValueTwo);
            double ExpectedValue = 3.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [Test]
        public void Given1GallonAndliter_WhenCompared_ShouldReturnEqualvolume()
        {
            double literOne = gallon.ConvertValueToLiter(Volume.Unit.GALLON_TO_LITER, 1.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 3.78);
            Assert.AreEqual(literOne, literTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1LiterAnd1000Mililiter_WhenCompared_ShouldReturnEqualVolume()
        {
            double literOne = miliLiter.ConvertValueToLiter(Volume.Unit.MILILITER_TO_LITER, 1000.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 1.0);
            Assert.AreEqual(literOne, literTwo);
        }
        [Test]
        public void Given1GallonAnd378iter_WhenAdded_ShouldReturnEqualTotalvolume()
        {
            double literOne = gallon.ConvertValueToLiter(Volume.Unit.GALLON_TO_LITER, 1.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 3.78);
            double ActualValue = liter.AddTWoUnitVolume(literOne, literTwo);
            double ExpectedValue = 7.55;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [Test]
        public void Given1000MililiterAnd1iter_WhenAdded_ShouldReturnEqualTotalvolume()
        {
            double literOne = miliLiter.ConvertValueToLiter(Volume.Unit.MILILITER_TO_LITER, 1000.0);
            double literTwo = liter.ConvertValueToLiter(Volume.Unit.LITER, 1.0);
            double ActualValue = liter.AddTWoUnitVolume(literOne, literTwo);
            double ExpectedValue =2.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
        [Test]
        public void Given1kgAnd1000Grams_WhenCompared_ShouldReturnEqualWeight()
        {
            double weightOne = grams.ConvertValueToKiloGrams(Weight.Unit.GRAMS_TO_KILOGRAMS, 1000.0);
            double weightTwo = killograms.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 1.0);
            Assert.AreEqual(weightOne, weightTwo);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Given1TonneAnd1000Killograms_WhenCompared_ShouldReturnEqualWeight()
        {
            double weightOne = killograms.ConvertValueToKiloGrams(Weight.Unit.KILOGRAMS, 1000.0);
            double weightTwo = tones.ConvertValueToKiloGrams(Weight.Unit.TONNE_TO_KILOGRAMS, 1.0);
            Assert.AreEqual(weightOne, weightTwo);
        }
        [Test]
        public void Given1TonneAnd1000Grams_WhenAdded_ShouldReturnEqualTotalWeight()
        {
            double weightOne = grams.ConvertValueToKiloGrams(Weight.Unit.GRAMS_TO_KILOGRAMS, 1000.0);
            double weightTwo = tones.ConvertValueToKiloGrams(Weight.Unit.TONNE_TO_KILOGRAMS, 1.0);
            double ActualValue = killograms.AddTWoUnits(weightOne, weightTwo);
            double ExpectedValue = 1001.0;
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}