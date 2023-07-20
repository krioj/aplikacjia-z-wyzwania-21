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
            if (number >= 0 && number <= 100)
            {
                this.score.Add(number);
            }//       /\
         //    [рахунок]
            else
            {
                Console.WriteLine("wybrana ocena nie istnieje");
            }
        }
        public void AddScore(string number)
        {

            if (float.TryParse(number, out float fl) && float.Parse(number) >= 0 && float.Parse(number) <= 100)
            {
                this.score.Add(fl);
            }
            else
            {
                switch (char.Parse(number))
                {
                    case 'A':
                    case 'a':
                        this.score.Add(100);
                        break;
                    case 'B':
                    case 'b':
                        this.score.Add(80);
                        break;
                    case 'C':
                    case 'c':
                        this.score.Add(60);
                        break;
                    case 'D':
                    case 'd':
                        this.score.Add(40);
                        break;
                    case 'E':
                    case 'e':
                        this.score.Add(20);
                        break;
                    default:
                        Console.WriteLine("wpisana ocena ne istnieje lub niemorzlywo wykonwertowac");
                        break;
                }
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

            switch (statistic.Average)                 // 
            {
                case var average when average >= 80:   
                    statistic.AverageLetter = 'A';     
                    break;
                case var average when average >= 60:
                    statistic.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistic.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistic.AverageLetter = 'D';
                    break;
                default:
                    statistic.AverageLetter = 'E';
                    break;
            }
            return statistic;
        }
        
    }
}
