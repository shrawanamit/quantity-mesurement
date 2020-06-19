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
            Feet feet2= new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }
    }
}