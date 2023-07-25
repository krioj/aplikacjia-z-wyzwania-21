using Wyzwanie21dn;

var emp = new EmployeeInFile("Artem", "Jablko", "18");
Console.WriteLine($"{emp.Name}, {emp.Surname}, {emp.Age} lat");
Console.WriteLine($"--------------------------------------------------");

emp.AddGrade("A");
emp.AddGrade("e");
emp.AddGrade("-4");
emp.AddGrade("1");
emp.AddGrade("2+");
emp.AddGrade(25.5f);
emp.AddGrade(59);

var stats = emp.GetStatistics();

Console.WriteLine($"Szrednia ocena: {stats.Average:N2}");                        // pokazuje tylko 2 liczby po ','
Console.WriteLine($"Szrebnia ocen w literah: {stats.AverageLetter}");
Console.WriteLine($"Maksymalna ocena: {stats.Max}");
Console.WriteLine($"Minimalna ocena: {stats.Min}");
Console.WriteLine($"Suma ocen: {stats.Sum}");


