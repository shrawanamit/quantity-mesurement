using NUnit.Framework;
using quantityMesurement;

namespace NUnitTestQuantityMesurement
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEquals()
        {
            Length feet1=new Length(0.0, Length.Unit.FEET);
            Length feet2=new Length(0.0, Length.Unit.FEET);
            Assert.AreEqual(feet1, feet2);
        }
        [Test]
        public void Given1FeetAnd2Feet_ShouldReturnNotEquals()
        {
            Length feet1 = new Length(1.0, Length.Unit.FEET);
            Length feet2 = new Length(2.0, Length.Unit.FEET);
            Assert.AreNotEqual(feet1, feet2);
        }
        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEquals()
        {
            Length inch1 =new Length(0.0, Length.Unit.FEET);
            Length inch2 = new Length(0.0, Length.Unit.FEET);
            Assert.AreEqual(inch1, inch2);
        }
        [Test]
        public void Given0FeetAnd1Feet_ShouldReturnNotEquals()
        {
            Length inch1 = new Length(0.0, Length.Unit.FEET);
            Length inch2 = new Length(1.0, Length.Unit.FEET);
            Assert.AreNotEqual(inch1, inch2);
        }
        [Test]
        public void Given1FeetAnd1Inch_ShouldReturnNotEquals()
        {
            Length length1= new Length(1.0, Length.Unit.FEET);
            Length inch1 = new Length(1.0, Length.Unit.INCH);
            Assert.AreNotEqual(length1, inch1);
        }
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length feet1 = new Length(0.0, Length.Unit.FEET);
            Length inch1 = new Length(0.0, Length.Unit.INCH);
            bool compareCheck=feet1.Compare(inch1);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given1FeetAnd1Inch_WhenCompared_ShouldReturnNotEqualLength()
        {
            Length feet1 = new Length(1.0, Length.Unit.FEET);
            Length inch1 = new Length(1.0, Length.Unit.INCH);
            bool compareCheck = feet1.Compare(inch1);
            Assert.False(compareCheck);
        }
        [Test]
        public void Given1FeetAnd1Feet_WhenCompared_ShouldReturnEqualLength()
        {
            Length feet1 = new Length(1.0, Length.Unit.FEET);
            Length feet2 = new Length(1.0, Length.Unit.FEET);
            bool compareCheck = feet1.Compare(feet2);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given1InchAnd1Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length inch1 = new Length(1.0, Length.Unit.INCH);
            Length inch2 = new Length(1.0, Length.Unit.INCH);
            bool compareCheck = inch1.Compare(inch2);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given1FeetAnd12Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length feet1 = new Length(1.0, Length.Unit.FEET);
            Length inch2 = new Length(12.0, Length.Unit.INCH);
            bool compareCheck = feet1.Compare(inch2);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given0YardAnd0Yard_ShouldReturnEquals()
        {
            Length yard1 = new Length(0.0, Length.Unit.YARD);
            Length yard2 = new Length(0.0, Length.Unit.YARD);
            Assert.AreEqual(yard1, yard2);
        }
        [Test]
        public void Given0YardAnd1Yard_ShouldReturnNotEquals()
        {
            Length yard1 = new Length(0.0, Length.Unit.YARD);
            Length yard2 = new Length(1.0, Length.Unit.YARD);
            Assert.AreNotEqual(yard1, yard2);
        }
        [Test]
        public void Given1FeetAnd1Yard_ShouldReturnNotEquals()
        {
            Length feet1 = new Length(1.0, Length.Unit.FEET);
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            Assert.AreNotEqual(feet1, yard1);
        }
        [Test]
        public void Given0FeetAnd0Yard_WhenCompared_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(0.0, Length.Unit.FEET);
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            bool compareCheck = feet1.Compare(yard1);
            Assert.False(compareCheck);
        }
        [Test]
        public void Given3FeetAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            Length feet1 = new Length(3.0, Length.Unit.FEET);
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            bool compareCheck = feet1.Compare(yard1);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given1FeetAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            Length feet1 = new Length(1.0, Length.Unit.FEET);
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            bool compareCheck = feet1.Compare(yard1);
            Assert.False(compareCheck);
        }
        [Test]
        public void Given1InchAnd1Yard_WhenCompared_ShouldReturnNotEqualLength()
        {
            Length inch1 = new Length(1.0, Length.Unit.INCH);
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            bool compareCheck = inch1.Compare(yard1);
            Assert.False(compareCheck);
        }
        [Test]
        public void Given1YardAnd36Inch_WhenCompared_ShouldReturnEqualLength()
        {
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            Length inch1 = new Length(36.0, Length.Unit.INCH);
            bool compareCheck = inch1.Compare(yard1);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given36InchAnd1Yard_WhenCompared_ShouldReturnEqualLength()
        {
            Length inch1 = new Length(36.0, Length.Unit.INCH);
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            bool compareCheck = inch1.Compare(yard1);
            Assert.True(compareCheck);
        }
        [Test]
        public void Given1YardAnd3Feet_WhenCompared_ShouldReturnEqualLength()
        {
            Length yard1 = new Length(1.0, Length.Unit.YARD);
            Length feet1 = new Length(3.0, Length.Unit.FEET);
            bool compareCheck = yard1.Compare(feet1);
            Assert.True(compareCheck);
        }
    }
}