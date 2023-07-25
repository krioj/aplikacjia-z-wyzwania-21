using ClassStatistics;

namespace Wyzwanie21dn
{
    internal class EmployeeInFile : EmployeeBase // : IEmployee
    {
        private List<float> grades = new List<float>();
        public const string filename = "grades.txt";
        public EmployeeInFile(string name, string surname, string age) : base(name, surname, age)
        {
        }

        public override void AddGrade(float grade)                          // zapisywanie danyh w plik
        {
            using (var writer = File.AppendText(filename))
            {
                writer.Write(grade);
                this.grades.Add(grade);
            }
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "+5":
                case "5+":
                    this.grades.Add(85);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "+1":
                case "1+":
                    this.grades.Add(5);
                    break;
                case "A":
                case "a":
                    this.grades.Add(100);
                    break;
                case "B":
                case "b":
                    this.grades.Add(80);
                    break;
                case "C":
                case "c":
                    this.grades.Add(60);
                    break;
                case "D":
                case "d":
                    this.grades.Add(40);
                    break;
                case "E":
                case "e":
                    this.grades.Add(20);
                    break;

                default:
                    throw new Exception("wybrana ocena nie istnieje");

            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("wybrana ocena nie istnieje");
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(filename))
            {
                writer.WriteLine(grade);
                this.grades.Add(grade);
            }
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()                          // metoda dla odczytywanie danyh z pliku
        {
            var grades = new List<float>();

            if (File.Exists($"{filename}"))                                 // sprawdza czy plik istnieje
            {
                using (var reader = File.OpenText(filename))                // 
                {
                    var line = reader.ReadLine();                           // pierwrsy odczyt linii (jeszli w pinii nic nie bedzie, to petla nie bedzie dzialac)
                    while (line != null)                                    // czy linija nie jest "null"-em
                    {
                        var number = float.Parse(line);                     // konwertacja linii
                        grades.Add(number);                                 // dodaje do tymczasowej listy "grades" ocene z pliku
                        line = reader.ReadLine();                           // odczyta kolejne linije
                    }
                }
            }
            return grades;                                                  
        }

        
        private Statistics CountStatistics(List<float> grades)              // Metoda jaka zwruci wypelniony obiekt z statystykami
        {
            var statistic = new Statistics();
            statistic.Average = 0;                                          // Avarage [середній] -> srednia wartosc
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            statistic.Sum = 0;
            foreach (var grade in grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
                statistic.Sum += grade;
            }
            statistic.Average = statistic.Average /= grades.Count;
            statistic.Sum = statistic.Sum = grades.Sum();
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
