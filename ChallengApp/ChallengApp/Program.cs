// zmienne
using System.ComponentModel.Design;

string name = "Ewa";
int age = 33;
char sex = 'k';
//instrukcje
if (age >= 120)
{
    Console.WriteLine("Jesteś martwy ;)");
}
else if (name == "Ewa" && age == 33 && sex == 'k')
{
    Console.WriteLine("EWA, lat 33");
}
else if (sex == 'k' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat, dokładnie ma " + age + " lat");
}
else if (sex == 'k' && age > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat, dokładnie ma " + age + " lat");
}
else if (age < 18 && sex != 'k')
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (sex == 'k')
{
    Console.WriteLine("Kobieta, " + age + " lat");
}
else
{
    Console.WriteLine("Mężczyzna, " + age + " lat");
}
