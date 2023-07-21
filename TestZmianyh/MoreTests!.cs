using ClassEmployee;
using ClassStatistics;

namespace TestZmianyh
{
    public class Tests
    {
        [Test]
        public void AddingGades_Aa()
        {
            var emp = new Employee("Artem", "Kostek");
            emp.AddScore("A");
            emp.AddScore("a");
            emp.AddScore(100);
            
            var stats = emp.GetAnEstimate();
            Assert.AreEqual(300, stats.Sum);
            Assert.AreEqual(100, stats.Min);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(100, stats.Average);
            Assert.AreEqual('A', stats.AverageLetter);
        }
        
        [Test]
        public void AddingGades_Bb()
        {
            var emp = new Employee("Artem", "Kostek");
            emp.AddScore("B");
            emp.AddScore("b");
            emp.AddScore(80);
            
            var stats = emp.GetAnEstimate();
            Assert.AreEqual(240, stats.Sum);
            Assert.AreEqual(80, stats.Min);
            Assert.AreEqual(80, stats.Max);
            Assert.AreEqual(80, stats.Average);
            Assert.AreEqual('B', stats.AverageLetter);
        }
        
        [Test]
        public void AddingGades_Cc()
        {
            var emp = new Employee("Artem", "Kostek");
            emp.AddScore("C");
            emp.AddScore("c");
            emp.AddScore(60);
            var stats = emp.GetAnEstimate();

            Assert.AreEqual(180, stats.Sum);
            Assert.AreEqual(60, stats.Min);
            Assert.AreEqual(60, stats.Max);
            Assert.AreEqual(60, stats.Average);
            Assert.AreEqual('C', stats.AverageLetter);
        }
        [Test]
        public void AddingGades_Dd()
        {
            var emp = new Employee("Artem", "Kostek");
            emp.AddScore("D");
            emp.AddScore("d");
            emp.AddScore(40);
            var stats = emp.GetAnEstimate();

            Assert.AreEqual(120, stats.Sum);
            Assert.AreEqual(40, stats.Min);
            Assert.AreEqual(40, stats.Max);
            Assert.AreEqual(40, stats.Average);
            Assert.AreEqual('D', stats.AverageLetter);
        }
        [Test]
        public void AddingGades_Ee()
        {
            var emp = new Employee("Artem", "Kostek");
            emp.AddScore("E");
            emp.AddScore("e");
            emp.AddScore(20);
            var stats = emp.GetAnEstimate();

            Assert.AreEqual(60, stats.Sum);
            Assert.AreEqual(20, stats.Min);
            Assert.AreEqual(20, stats.Max);
            Assert.AreEqual(20, stats.Average);
            Assert.AreEqual('E', stats.AverageLetter);
        }
        [Test]
        public void AddingGades()
        {
            var emp = new Employee("Artem", "Kostek");
            emp.AddScore("d");
            emp.AddScore("A");
            emp.AddScore(6);
            emp.AddScore("E");
            emp.AddScore(55);

            var stats = emp.GetAnEstimate();
            Assert.AreEqual(221, stats.Sum);
            Assert.AreEqual(6, stats.Min);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(44.2, Math.Round(stats.Average, 2));        // Math.Round(stats.Average, 2) - wydaje tylko 2 cyferki po ","
            Assert.AreEqual('C', stats.AverageLetter);
        }
    }
}