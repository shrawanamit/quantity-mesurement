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
        public void Given0InchAnd0Inch_ShouldReturnNotEquals()
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

    }
}