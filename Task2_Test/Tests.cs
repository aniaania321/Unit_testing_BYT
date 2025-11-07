using Task2;

namespace Task2_Test
{
    public class Tests
    {
        private readonly Calculator calculator1 = new Calculator(10,2,"/");

        [Test]
        public void TestDivision()
        {
            Assert.That(calculator1.Calculate(), Is.EqualTo(5).Within(0.001));
        }
        
        private readonly Calculator calculator2 = new Calculator(10,5,"*");


        [Test]
        public void TestMultiplication()
        {
            Assert.That(calculator2.Calculate(), Is.EqualTo(50).Within(0.001));
        }
        
        private readonly Calculator calculator3 = new Calculator(8,12,"+");


        [Test]
        public void TestAddition()
        {
            Assert.That(calculator3.Calculate(), Is.EqualTo(20).Within(0.001));
        }
        
        private readonly Calculator calculator4 = new Calculator(10,8,"-");


        [Test]
        public void TestSubtraction()
        {
            Assert.That(calculator4.Calculate(), Is.EqualTo(2).Within(0.001));
        }
        
        private readonly Calculator calculator5 = new Calculator(3,0,"/");
        
        [Test]
        public void TestDivisonByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator5.Calculate());
        }
        
        private readonly Calculator calculator6 = new Calculator(4,2,"}");
        
        [Test]
        public void TestInvalidOperation()
        {
            Assert.Throws<InvalidOperationException>(() => calculator6.Calculate());
        }
        
        private readonly Calculator calculator7 = new Calculator(-6,8,"-");

        [Test]
        public void TestNegativeNumbers()
        {
            Assert.That(calculator7.Calculate(), Is.EqualTo(-14).Within(0.001));
        }
        
        private readonly Calculator calculator8 = new Calculator(0.0001,10,"/");

        [Test]
        public void TestSmallNumbers()
        {
            Assert.That(calculator8.Calculate(), Is.EqualTo(1E-05).Within(1e-6));
        }
        
        private readonly Calculator calculator9 = new Calculator(100000000000,500,"/");
        
        [Test]
        public void TestBigNumbers()
        {
            Assert.That(calculator9.Calculate(), Is.EqualTo(200000000).Within(0.001));
        }
    }
}