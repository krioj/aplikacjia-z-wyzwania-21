using Wyzwanie21dn;

var emp = new EmployeeInFile("Artem", "Jablko", "18");

Console.WriteLine($"Witam {emp.Name} w programie dla oceny pracownikuw!");
Console.WriteLine($"--------------------------------------------------");

emp.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano ocene");
}

while (true)
{
    Console.WriteLine("Ile ocen podamy?");
    try
    {
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine($"Musis podac ocene tyle raz: {r}");
        for (int i = 0; i < r; i++)
        {
            emp.AddGrade(Console.ReadLine());                          // odczyruje dane z konsoli (od urzytkownika) i konwertuje w typ danyh "float"
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Zle podana ocena lub ilosc");
    }

    var stats = emp.GetStatistics();
    Console.WriteLine($"Szrednia ocena: {stats.Average:N2}");                        // pokazuje tylko 2 liczby po ','
    Console.WriteLine($"Szrebnia ocen w literah: {stats.AverageLetter}");
    Console.WriteLine($"Maksymalna ocena: {stats.Max}");
    Console.WriteLine($"Minimalna ocena: {stats.Min}");
    Console.WriteLine($"Suma ocen: {stats.Sum}");

    string q = Console.ReadLine();

    if (q == "q")
        break;
}