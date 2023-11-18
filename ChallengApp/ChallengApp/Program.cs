using ChallengApp;

Employee employee1 = new Employee("Jacek", "naglik", 19);
Employee employee2 = new Employee("Paweł", "Nowak", 55);
Employee employee3 = new Employee("Jola", "Krzak", 35);

employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(6);
employee1.AddScore(8);

employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(9);
employee2.AddScore(6);

employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(8);
employee3.AddScore(10);

List<Employee> workers = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in workers)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

if (employee1.Result != employee2.Result && employee1.Result != employee3.Result && employee2.Result != employee3.Result)
{
    Console.WriteLine("Pracownik z największym wynikiem to " + employeeWithMaxResult.Name + " uzyskał/a " + employeeWithMaxResult.Result + " punktów!");
}

if (employeeWithMaxResult.Result == employee1.Result && employeeWithMaxResult.Result == employee2.Result && employeeWithMaxResult.Result == employee3.Result)
{
    Console.WriteLine("Pracownicy " + employee1.Name + " " + employee2.Name + " " + employee3.Name + " razem uzykali najlepszy wynik, każdy po " + employeeWithMaxResult.Result + " punktów!");
}
else if (employeeWithMaxResult.Result == employee1.Result && employeeWithMaxResult.Result == employee2.Result)
{
    Console.WriteLine("Pracownicy " + employee1.Name + " " + employee2.Name + " razem uzykali najlepszy wynik, każdy po " + employeeWithMaxResult.Result + " punktów!");
}
else if (employeeWithMaxResult.Result == employee2.Result && employeeWithMaxResult.Result == employee3.Result)
{
    Console.WriteLine("Pracownicy " + employee2.Name + " " + employee3.Name + " razem uzykali najlepszy wynik, każdy po " + employeeWithMaxResult.Result + " punktów!");
}
else if(employeeWithMaxResult.Result == employee1.Result && employeeWithMaxResult.Result == employee3.Result)
{
    Console.WriteLine("Pracownicy " + employee1.Name + " " + employee3.Name + " razem uzykali najlepszy wynik, każdy po " + employeeWithMaxResult.Result + " punktów!");
}
