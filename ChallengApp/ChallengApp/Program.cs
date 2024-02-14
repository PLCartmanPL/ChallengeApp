using ChallengApp;

var employee = new Employee("Adam", "Naglik");
employee.AddGrade(800);
employee.AddGrade("adam");
employee.AddGrade(90);

var statsitic = employee.GetStatistics();

Console.WriteLine($"Wartość Średnia: {statsitic.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic.Max}");
