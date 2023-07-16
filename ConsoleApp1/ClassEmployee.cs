using ClassStatistics;

namespace ClassEmployee
{
    public class Employee
    {
        private List<int> score = new List<int>();
        
        public Employee(string imie, string Nazwisko)
        {
            this.Name = imie;
            this.Surname = Nazwisko;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public void AddScore(int name)
        {
            this.score.Add(name);
        }//       /\
         //    [рахунок]
        public Statistics GetAnEstimate()         // Metoda jaka zwruci wypelniony obiekt z statystykami
        {
            var oceny = new Statistics();
            oceny.Average = 0;              // Avarage [середній], srednia wartosc
            oceny.Max = float.MinValue;
            oceny.Min = float.MaxValue;
            oceny.Suma = 0;
            
            foreach (var grade in this.score)
            {
                oceny.Max = Math.Max(oceny.Max, grade);
                oceny.Min = Math.Min(oceny.Min, grade);
                oceny.Average += grade;
                oceny.Suma += grade;
            }

            oceny.Average = oceny.Average /= this.score.Count;
            oceny.Suma = oceny.Suma = this.score.Sum();
            return oceny;
        }










    }
}
