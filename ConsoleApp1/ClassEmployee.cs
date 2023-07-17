using ClassStatistics;

namespace ClassEmployee
{
    public class Employee
    {
        private List<float> score = new List<float>();
        
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public void AddScore(float number)
        {
            if(number >= -10 && number <= 10)
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
            if (float.TryParse(number, out float resalt) && int.Parse(number) >= -10 && int.Parse(number) <= 10)
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion \"string\" ({number}) is not possible or this number is out of range");
            }
        }
        public void AddScore(sbyte number)
        {
            if (float.TryParse(Convert.ToString(number), out float resalt) && number >= -10 && number <= 10)
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion \"sbyte\" ({number}) is not possible or this number is out of range");
            }
        }
        public void AddScore(short number)
        {
            if (float.TryParse(Convert.ToString(number), out float resalt))
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion \"short\" ({number}) is not possible or this number is out of range");
            }
        }
        public void AddScore(int number)
        {
            if (float.TryParse(Convert.ToString(number), out float resalt))
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion  \"int\" ({number}) is not possible or this number is out of range");
            }
        }
        public void AddScore(long number)
        {
            if (float.TryParse(Convert.ToString(number), out float resalt))
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion \"long\" ({number}) is not possible or this number is out of range");
            }
        }
        public void AddScore(double number)
        {
            if (float.TryParse(Convert.ToString(number), out float resalt))
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion \"double\" ({number}) is not possible or this number is out of range");
            }
        }
        public void AddScore(decimal number)
        {
            if (float.TryParse(Convert.ToString(number), out float resalt))
            {
                this.AddScore(resalt);
            }
            else
            {
                Console.WriteLine($"conversion \"decimal\" ({number}) is not possible or this number is out of range");
            }
        }

        public Statistics GetAnEstimate()         // Metoda jaka zwruci wypelniony obiekt z statystykami
        {
            var statistic = new Statistics();
            statistic.Average = 0;              // Avarage [середній], srednia wartosc
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
