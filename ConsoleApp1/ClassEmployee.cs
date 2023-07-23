using ClassStatistics;
using Wyzwanie21dn;

namespace ClassEmployee
{
    public class Employee : Person
    {
        private List<float> score = new List<float>();
        public Employee(string name)
            : base(name)
        {
        }
        public Employee(string name, string surname)
                    : base(name, surname)
        {
        }
        public Employee(string name, string surname, string age)
            : base(name, surname, age)
        {
        }

        public void AddScore(float number)
        {
            if (number >= 0 && number <= 100)
            {
                this.score.Add(number);                                        
            }//       /\
             //    [рахунок]
            else
            {
                throw new Exception("wybrana ocena nie istnieje");             // co jest w "", bedzie zapisane w zmianu "Exception.Message"
            }//   /\
        }//[Wrzuc], [вкинути]
        public void AddScore(string number)
        {
            switch (number)
            {
                case "6":
                    this.score.Add(105);
                    break;
                case "5":
                    this.score.Add(85);
                    break;
                case "4":
                    this.score.Add(65);
                    break;
                case "3":
                    this.score.Add(45);
                    break;
                case "2":
                    this.score.Add(25);
                    break;
                case "1":
                    this.score.Add(5);
                    break;
                case "-6":
                case "6-":
                    this.score.Add(95);
                    break;
                case "-5":
                case "5-":
                    this.score.Add(75);
                    break;
                case "-4":
                case "4-":
                    this.score.Add(55);
                    break;
                case "-3":
                case "3-":
                    this.score.Add(35);
                    break;
                case "-2":
                case "2-":
                    this.score.Add(15);
                    break;
                case "-1":
                case "1-":
                    this.score.Add(-5);
                    break;
                case "+6":
                case "6+":
                    this.score.Add(105);
                    break;
                case "+5":
                case "5+":
                    this.score.Add(85);
                    break;
                case "+4":
                case "4+":
                    this.score.Add(65);
                    break;
                case "+3":
                case "3+":
                    this.score.Add(45);
                    break;
                case "+2":
                case "2+":
                    this.score.Add(25);
                    break;
                case "+1":
                case "1+":
                    this.score.Add(5);
                    break;
                case "A":
                case "a":
                    this.score.Add(100);
                    break;
                case "B":
                case "b":
                    this.score.Add(80);
                    break;
                case "C":
                case "c":
                    this.score.Add(60);
                    break;
                case "D":
                case "d":
                    this.score.Add(40);
                    break;
                case "E":
                case "e":
                    this.score.Add(20);
                    break;
                
                default:
                    throw new Exception("wybrana ocena nie istnieje");

            }
        }
        public void AddScore(char number)
        {
            switch (number)
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
                    throw new Exception("wybrana ocena nie istnieje");
            }
        }
        public Statistics GetAnEstimate()                    // Metoda jaka zwruci wypelniony obiekt z statystykami
        {
            var statistic = new Statistics();
            statistic.Average = 0;                           // Avarage [середній] -> srednia wartosc
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
            switch (statistic.Average)
            {
                case var average when average >= 81:
                    statistic.AverageLetter = 'A';
                    break;
                case var average when average >= 61:
                    statistic.AverageLetter = 'B';
                    break;
                case var average when average >= 41:
                    statistic.AverageLetter = 'C';
                    break;
                case var average when average >= 21:
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

