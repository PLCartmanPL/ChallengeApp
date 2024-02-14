using ChallengApp;

var employee = new Employee("Adam", "Naglik");

employee.AddGrade("adm");
employee.AddGrade(24);
employee.AddGrade(800);
employee.AddGrade(11.466);

var statsitic = employee.GetStatistics();
var statsitic1 = employee.GetStatisticsWithFor();
var statsitic2 = employee.GetStatisticsWithDoWhile();
var statsitic3 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Wartość Średnia: {statsitic.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic.Max}");
Console.WriteLine();
Console.WriteLine($"Wartość Średnia: {statsitic1.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic1.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic1.Max}");
Console.WriteLine();
Console.WriteLine($"Wartość Średnia: {statsitic2.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic2.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic2.Max}");
Console.WriteLine();
Console.WriteLine($"Wartość Średnia: {statsitic3.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic3.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic3.Max}");