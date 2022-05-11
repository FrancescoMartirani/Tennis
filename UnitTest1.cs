using NUnit.Framework;

namespace TestProject1
{
    public class Test
    {
        private Pointer pointer;

        [SetUp]
        public void Setup()
        {

            pointer = new Pointer();

        }

        [TestCase(3,0, "40-Amore")]
        [TestCase(0,1, "Amore-15")]
        [TestCase(2,3, "30-40")]
        [TestCase(0,0, "Amore-Amore")]
        [TestCase(5,5, "Deuce")]
        [TestCase(5,6, "5-Vantaggio")]
        public void Points(int punteggio1, int punteggio2, string expected)
        {

            Assert.AreEqual(pointer.getScore(punteggio1, punteggio2),expected);
        }
    }
}