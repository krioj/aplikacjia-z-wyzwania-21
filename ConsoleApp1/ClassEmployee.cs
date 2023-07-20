using ClassStatistics;

namespace ClassEmployee
{
    public class Employee
    {
        private List<float> score = new List<float>();
        
        public Employee(string name, string surname)            // 
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }                // tworzenia 2-h zmianyh dla clasa 
        public string Surname { get; private set; }
        
        public void AddScore(float number)
        {
            if(number >= 0 && number <= 100)
            {
                this.score.Add(number);
            }
            else
            {
                Console.WriteLine("this number is out of range");
            }
        }//       /\
         //    [рахунок]
        public void AddScore(string number)
        {
            if (float.TryParse(number, out float resalt) && int.Parse(number) >= 0 && int.Parse(number) <= 100)
            {
                this.score.Add(resalt);
            }
            else
            {
                Console.WriteLine("this number is out of range");
            }
        }
        public Statistics GetAnEstimate()         // Metoda jaka zwruci wypelniony obiekt z statystykami
        {
            var statistic = new Statistics();
            statistic.Average = 0;              // Avarage [середній] -> srednia wartosc
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            statistic.Sum = 0;
            
            foreach (var grade in this.score)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
                statistic.Sum += grade;
                
            }
            statistic.Average = statistic.Average /= this.score.Count;
            statistic.Sum = statistic.Sum = this.score.Sum();
            return statistic;
        }
        
    }
}
