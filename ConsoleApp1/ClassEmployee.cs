namespace classEmployee
{
    public class Employee
    {
        public static string STIK = "ksaf";        // kreacja statycznej zmiannej, "static" mozna wykorzystac i dla konstruktora (ale wteda bede pracowac tylko w klasie)
        public List<int> score = new List<int>();

        public Employee(string imie, string nazwisko, string wiek)                     // stworzyl konstruktor
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public string Wiek { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }                                                                                               // potszeba dodacz liczbe (jusz dodal "5")
        //                                                                                                                   \/
        public void AddScore(int number)    // dodaje punkty uzytkownikowi (wykorzystac morzna tak:    JakasZmianna.AddScore(5))
        {
            this.score.Add(number);         // dodaje liczby do zmianna "score"                 
        }
    }
}
