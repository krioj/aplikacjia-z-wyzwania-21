using ClassEmployee;

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
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(15, stat.Sum);
            Assert.AreEqual(7, stat.Max);
            Assert.AreEqual(3, stat.Min);
            Assert.AreEqual(5, stat.Average);
        }
        [Test]
        public void AddingNegativeGrades()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore(-5);
            emp.AddScore(-7);
            emp.AddScore(-3);
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(-15, stat.Sum);
            Assert.AreEqual(-3, stat.Max);
            Assert.AreEqual(-7, stat.Min);
            Assert.AreEqual(-5, stat.Average);
        }
        [Test]
        public void AddingGrades()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore(-5);
            emp.AddScore(7);
            emp.AddScore(-3);
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(-1, stat.Sum);
            Assert.AreEqual(7, stat.Max);
            Assert.AreEqual(-5, stat.Min);
            Assert.AreEqual(-0.33, Math.Round(stat.Average, 2));
        }
        [Test]
        public void AddingGradesNegativeString()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore("-5");
            emp.AddScore("-3");
            emp.AddScore("-7");
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(-15, stat.Sum);
            Assert.AreEqual(-3, stat.Max);
            Assert.AreEqual(-7, stat.Min);
            Assert.AreEqual(-5, stat.Average);
        }
        [Test]
        public void AddingGradesPositiveString()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore("5");
            emp.AddScore("3");
            emp.AddScore("7");
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(15, stat.Sum);
            Assert.AreEqual(7, stat.Max);
            Assert.AreEqual(3, stat.Min);
            Assert.AreEqual(5, stat.Average);
        }
        [Test]
        public void AddingGradesString()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore("5");
            emp.AddScore("-3");
            emp.AddScore("7");
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(9, stat.Sum);
            Assert.AreEqual(7, stat.Max);
            Assert.AreEqual(-3, stat.Min);
            Assert.AreEqual(3, stat.Average);
        }
        [Test]
        public void AddingStringAndConvert()
        {
            var emp = new Employee("Aboba", "Abobes");
            emp.AddScore("5");
            emp.AddScore("-3");
            emp.AddScore("7");
            var stat = emp.GetAnEstimate();
            Assert.AreEqual(9, stat.Sum);
            Assert.AreEqual(7, stat.Max);
            Assert.AreEqual(-3, stat.Min);
            Assert.AreEqual(3, stat.Average);
        }
    }
}
