using ClassStatistics;

namespace Wyzwanie21dn
{
    internal class Supervisor : IEmployee
    {
        public string Name => "Szliwa";

        public string Surname => "Jablkowa";

        public string Age => "18";

        private List<float> grades = new List<float>();

        public void AddGrade(float grade)                          // zapisywanie danyh w plik
        {
            this.grades.Add(grade);   
        }

        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade((float)100);
                    break;
                case "5":
                    this.AddGrade((float)80);
                    break;
                case "4":
                    this.AddGrade((float)60);
                    break;
                case "3":
                    this.AddGrade((float)40);
                    break;
                case "2":
                    this.AddGrade((float)20);
                    break;
                case "1":
                    this.AddGrade((float)0);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade((float)95);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade((float)75);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade((float)55);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade((float)35);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade((float)15);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade((float)85);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade((float)65);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade((float)45);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade((float)25);
                    break;
                case "+1":
                case "1+":
                    this.AddGrade((float)5);
                    break;
                case "A":
                case "a":
                    this.AddGrade((float)100);
                    break;
                case "B":
                case "b":
                    this.AddGrade((float)80);
                    break;
                case "C":
                case "c":
                    this.AddGrade((float)60);
                    break;
                case "D":
                case "d":
                    this.AddGrade((float)40);
                    break;
                case "E":
                case "e":
                    this.AddGrade((float)20);
                    break;
                default:
                    throw new Exception("wybrana ocena nie istnieje");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade((float)100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade((float)80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade((float)60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade((float)40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade((float)20);
                    break;
                default:
                    throw new Exception("wybrana ocena nie istnieje");
            }
        }

        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}