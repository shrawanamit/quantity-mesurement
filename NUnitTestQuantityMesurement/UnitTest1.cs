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

        [SetUp]
        public void Setup()
        {
            this.yard = new Length();
            this.feet = new Length();
            this.inch = new Length();
            this.centimeter = new Length();
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
    }
}