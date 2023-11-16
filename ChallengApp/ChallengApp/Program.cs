// założenia
int number = 80222;
string numberInString = number.ToString();
char[] dane = numberInString.ToArray();
var i = 0;
//tablica wartości
List<int> liczba = new List<int>();
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
liczba.Add(0);
//działania na liczbach
foreach (char dodawanie in dane)
{
    if (dodawanie == '0')
    {
        liczba[0]++;
    }
    else if (dodawanie == '1')
    {
        liczba[1]++;
    }
    else if (dodawanie == '2')
    {
        liczba[2]++;
    }
    else if (dodawanie == '3')
    {
        liczba[3]++;
    }
    else if (dodawanie == '4')
    {
        liczba[4]++;
    }
    else if (dodawanie == '5')
    {
        liczba[5]++;
    }
    else if (dodawanie == '6')
    {
        liczba[6]++;
    }
    else if (dodawanie == '7')
    {
        liczba[7]++;
    }
    else if (dodawanie == '8')
    {
        liczba[8]++;
    }
    else if (dodawanie == '9')
    {
        liczba[9]++;
    }
}
// Dynamiczne yświetlanie wyniku
Console.WriteLine("W liczbie " + number);
foreach (var wyniki in liczba)
{
    Console.WriteLine("cyfra " + i++ + " występuje " + wyniki + " razy");
}
