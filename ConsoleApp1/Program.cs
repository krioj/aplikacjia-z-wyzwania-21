using ClassEmployee;
using ClassStatistics;

char q;
Console.WriteLine($"Podaj imie, nazwisko i wiek pracownika");
var emp = new Employee(Console.ReadLine(), Console.ReadLine(), (Console.ReadLine()));
Console.WriteLine($"{emp.Name} {emp.Surname}, {emp.Age} lat");
Console.WriteLine("-----------------------------------------------------");
do
{
    Console.WriteLine("ile ocen dodamy?");
    if (int.TryParse(Console.ReadLine(), out int a))
    {
        Console.WriteLine("musis podac liczbe lub litere dla karzdej oceny");
        try
        {
            for (int i = 0; i < a; i++)
            {
                emp.AddScore(Console.ReadLine());                                   // potencijno niebiezpiecny kod (morze byc blad)
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Zle podana ocena");
        }
    }
    else
    {
        Console.WriteLine($"zle wpisana ilosc ({a})");
    }
    var stats = emp.GetAnEstimate();

    Console.WriteLine($"Szrednia ocena: {stats.Average:N2}");                        // pokazuje tylko 2 liczby po ','
    Console.WriteLine($"Szrebnia ocen w literah: {stats.AverageLetter}");
    Console.WriteLine($"Maksymalna ocena: {stats.Max}");
    Console.WriteLine($"Minimalna ocena: {stats.Min}");
    Console.WriteLine($"Suma ocen: {stats.Sum}");
    q = char.Parse(Console.ReadLine());
} while ('q' != q);


