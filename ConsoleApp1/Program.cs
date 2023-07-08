/* UWAGA! co jest napisane w kwadratowych nawiasach (np.: "[картопля]") - to jest wytlumaczone dla mnie, zeby szypciej uczyc pilski
 * dzieki za uwage ;-).
 * 
 * double;   lub   Float;   ->   z pływaniem ",", jesli wrzuca blad, to musis sprobowac wpisa zamiast "," kropku "." (u mnie byl taki problem).
Float.MaxValea   lub   Float.MinVale;   ->   pokazuje max/min liczb[чисел].
var   ->   uniwersalny typ zmiannyh.
var a = q.ToArray();   ->   tworzy tabelę.
bool   ->   'true'   lub   'false'.                                (gruppy zmiennyh)
!=   ->   nie ruwno.
==   ->   ruwno.
>= lub <=    ->   > i == lub < i ==.
||   ==   or.
&&   ==   and.
!   ==   nie   ->   !(a > 5) - "a" nie jest wiencej 5-cu.           (nazywa to operatory)
int[] tablica = new int[10];   ->   zwykla  tablica z 10-u elemientow.
tablica[0] = "poniedelnik"   ->   zapisalismy text w komórka pod numerem 0.
string[] tablica = { "a", "w", "g", "h", "l"}   ->   stwuzre tablice tylko szypciej.
for (i = 0; i < 10; i++)   ->   cykl
{ 
    Console.WriteLine("a");   ->   napisze "a" 10 raz
}. 
string[] tablica = { "a", "s", "h" }
Console.WriteLine(tablica.Length);   ->   napisze "3" w konsoli.
tablica.Length   ->   jeszli tanlica ma 14 komurek, to wyda liczbe 14.
List<string> TablicaList = new List<string>();   ->   tworze modefikowana tablica "List" (początkowo[изначально] tu niema rzadnej komurki)
TablicaList.Add("a");   ->   dodaje komurke (z zawartośća[змістом] "a") na koniec tablicy
foreach(var n in TablicaList)   ->   wykorzysta dane z wybranej tablicy "TablicaList" 
{
     Console.WriteLine(n)   ->   napisze w konsoli zawartośća ze wszystkich komurek pokolei (kazda komurka bedzie wypisywana z nowej linii)
}.
int a = 4209;                             
string a = b.ToString();   ->   konwertuje zmiana "a" z typu "int" w typ "string"
char[] letters = a.ToArray();   ->   wtiaga symwoly z zmianej (nap. char[1] - wpisze "2").
Ctrl + K + D   ->   wyruwnia kod
var pi = Math.PI;               // czyslo pi, mozna tak ja otszymac
ctrl + R + R   ->   morzna zmienic cos (napsz. nazwe zmiannej) w calem plicie
ctrl + k + d   ->   wyruwnia cok
ctrl + .   ->   napisze morzliwy sposub rozwiezywania 
*/

using classEmployee;

Employee user1 = new Employee("Marek ", "Pomidor", "23 lat");
Employee user2 = new Employee("Garek ", "Szliwa", "31 lat");
Employee user3 = new Employee("Darek ", "Limon", "19 lat");

user1.AddScore(9);
user1.AddScore(4);
user1.AddScore(2);


user2.AddScore(2);
user2.AddScore(7);
user2.AddScore(10);


user3.AddScore(4);
user3.AddScore(6);
user3.AddScore(10);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};
int maxResult = -1;
Employee userMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)                      // sprawdza czy suma z "user1/2/3" wienksza niz "maxResult" (jeszli bedzie "truy" to w zmianu "maxResult" bedzie zapisane dany liciebnika co jest wienkszy)
    {
        userMaxResult = user;                         // zmienia znacienia "null" na cos inne
        maxResult = user.Result;                      // zmiana mniejsego liciebnika na wiengszy 
    }
}
Console.WriteLine("Najlepszy pracownikiem jest " + userMaxResult.Imie + userMaxResult.Nazwisko + ", on ma " + userMaxResult.Wiek + "!");
