// założenia
int number = 80222;
string numberInString = number.ToString();
char[] data = numberInString.ToArray();
var i = 0;
//tablica wartości
List<int> counter = new List<int>();
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
counter.Add(0);
//działania na counterch
foreach (char adding in data)
{
    if (adding == '0')
    {
        counter[0]++;
    }
    else if (adding == '1')
    {
        counter[1]++;
    }
    else if (adding == '2')
    {
        counter[2]++;
    }
    else if (adding == '3')
    {
        counter[3]++;
    }
    else if (adding == '4')
    {
        counter[4]++;
    }
    else if (adding == '5')
    {
        counter[5]++;
    }
    else if (adding == '6')
    {
        counter[6]++;
    }
    else if (adding == '7')
    {
        counter[7]++;
    }
    else if (adding == '8')
    {
        counter[8]++;
    }
    else if (adding == '9')
    {
        counter[9]++;
    }
}
// Dynamiczne yświetlanie wyniku
Console.WriteLine("W liczbie " + number);
foreach (var result in counter)
{
    Console.WriteLine("cyfra " + i++ + " występuje " + result + " razy");
}
