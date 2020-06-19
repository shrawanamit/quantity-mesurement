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
            Feet feet1=new Feet(0.0);
            Feet feet2=new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }
        [Test]
        public void Given1FeetAnd2Feet_ShouldReturnNotEquals()
        {
            Feet feet1 = new Feet(1.0);
            Feet feet2 = new Feet(2.0);
            Assert.AreNotEqual(feet1, feet2);
        }
        [Test]
        public void Given0InchAnd0Inch_ShouldReturnEquals()
        {
            Inch inch1=new Inch(0.0);
            Inch inch2 = new Inch(0.0);
            Assert.AreEqual(inch1, inch2);
        }
        [Test]
        public void Given0InchAnd0Inch_ShouldReturnNotEquals()
        {
            Inch inch1 = new Inch(0.0);
            Inch inch2 = new Inch(1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

    }
}