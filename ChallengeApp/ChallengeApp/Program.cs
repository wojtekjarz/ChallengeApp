
using System.ComponentModel.Design;

var imie = "Ewa";
var plec = "kobieta";
var wiek = 19;

if (imie == "Ewa" && wiek == 33 && plec =="kobieta")
{
    Console.WriteLine("Ewa, lat 33");
}

else if (plec == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}

else if (plec == "mezczyzna" && wiek <18) 
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
