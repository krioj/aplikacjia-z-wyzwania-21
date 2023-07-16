using ClassEmployee;
using System.Security.Cryptography;
using System.Threading.Tasks.Sources;

namespace TestZmianyh
{
    public class Tests
    {
        [Test]
        public void AddingPositiveGrades()
        {
            var emp = new Employee("Aboba","Abobes");
            emp.AddScore(5);
            emp.AddScore(7);
            emp.AddScore(3);
            var statistic = emp.GetAnEstimate();
            Assert.AreEqual(15, statistic.Suma);
            Assert.AreEqual(7, statistic.Max);
            Assert.AreEqual(3, statistic.Min);
            Assert.AreEqual(5, statistic.Average);
        }
        [Test]
        public void AddingNegativeGrades()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore(-5);
            emp.AddScore(-7);
            emp.AddScore(-3);
            var statistic = emp.GetAnEstimate();
            Assert.AreEqual(-15, statistic.Suma);
            Assert.AreEqual(-3, statistic.Max);
            Assert.AreEqual(-7, statistic.Min);
            Assert.AreEqual(-5, statistic.Average);
        }
        [Test]
        public void AddingGrades()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore(-5);
            emp.AddScore(7);
            emp.AddScore(-3);
            var statistic = emp.GetAnEstimate();
            Assert.AreEqual(-1, statistic.Suma);
            Assert.AreEqual(7, statistic.Max);
            Assert.AreEqual(-5, statistic.Min);
            Assert.AreEqual(-0.33, Math.Round(statistic.Average, 2));
        }
    }
}
