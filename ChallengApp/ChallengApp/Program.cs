﻿using ChallengApp;
Console.WriteLine("Witamy w programie do oceny pracownika");
Console.WriteLine("======================================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Naglik", 'M');
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano Nową ocene");
}


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catch: {e.Message}");
    }
}
var statsitic = employee.GetStatistics();

Console.WriteLine($"Wartość Średnia: {statsitic.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic.Max}");
Console.WriteLine($"Liczba ocen: {statsitic.NumberOfGrades}");
Console.WriteLine($"Wartość średnia literą: {statsitic.AverageLetter}");
Console.WriteLine();

