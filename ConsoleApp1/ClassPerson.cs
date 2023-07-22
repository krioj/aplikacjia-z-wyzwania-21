
namespace Wyzwanie21dn
{
    public abstract class Person
    {
        public Person()                           // name jest pszekazana pszez ":base" z clasy "Person" (tomu i nie wywala blad)
           : this("no name")                                                       // odwoluje do klasy bazowej (w tym pszypadku do "Persone"), do zmianej "name"
        {
        }
        public Person(string name)
            : this(name, "no surname")
        {
            this.Name = name;
        }
        public Person(string name, string surname)
            :this(name, surname, "niema takiegi wieku")
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }                // tworzenia 2-h zmianyh dla clasa 
        public string Surname { get; private set; }
        public string Age { get; private set; }
    }
}
