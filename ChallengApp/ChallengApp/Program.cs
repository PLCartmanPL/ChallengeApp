using ChallengApp;

var employee = new Employee("Adam", "Naglik");
employee.AddGrade("adam");
employee.AddGrade(1000);
employee.AddGrade(12);
employee.AddGrade(24);
employee.AddGrade(11.466);

var statsitic = employee.GetStatistics();

Console.WriteLine($"Wartość Średnia: {statsitic.Average:N2}");
Console.WriteLine($"Wartość Minimalna: {statsitic.Min}");
Console.WriteLine($"Wartość Maksymalna: {statsitic.Max}");
