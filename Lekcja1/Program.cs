// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, Kajetan and Lukasz 01.07.23");
string[] imie = { "Damian", "Wiktoria", "Dominik" };
string[] nazwisko = { "Konieczny", "Dudek", "Kowalski" };
int[] wiek = { 20, 42, 33 };
string[] plec = { "Mężczyzna", "Kobieta", "Mężczyzna" };
int maks_wiek = 0;
int j = 0;
foreach (string i in imie)
{
    Console.WriteLine(i);
}
foreach (int i in wiek)
{
    if (i > maks_wiek)
    {
        maks_wiek = i;
        j = Array.IndexOf(wiek, i);
    }
}
Console.WriteLine("Najstarsza osoba: " + imie[j] + " " + nazwisko[j] + " " + wiek[j] + " " + plec[j]);


//test listy

List<string> dni = new List<string>();
dni.Add("poniedziałek");
dni.Add("wtorek");
dni.Add("środa");
dni.Add("czwartek");
dni.Add("piątek");
dni.Add("sobota");
dni.Add("niedziela");

foreach (string dn in dni)
{
    Console.WriteLine(dn);
}
