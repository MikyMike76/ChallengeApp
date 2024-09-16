using ChallengeApp;

Employee employee1 = new Employee("Michal", "Kowalski", 55);
Employee employee2 = new Employee("Aneta", "Borkowska", 34);
Employee employee3 = new Employee("Artur", "Zagrabski", 23);

employee1.AddScore(5);
employee2.AddScore(2);
employee3.AddScore(1);
employee1.AddScore(3);
employee2.AddScore(4);
employee3.AddScore(8);
employee1.AddScore(7);
employee2.AddScore(3);
employee3.AddScore(0);
employee1.AddScore(10);
employee2.AddScore(9);
employee3.AddScore(10);
employee1.AddScore(1);
employee2.AddScore(7);
employee3.AddScore(8);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxScore = 0;
Employee MaxScoreEmp = null;

foreach (var employee in  employees)
{
    if (employee.Score > maxScore)
    {
        maxScore = employee.Score;
        MaxScoreEmp = employee;
    }
}

Console.WriteLine("Imię, nazwisko i punktacja najlepszego: {0} {1} - {2} pkt", MaxScoreEmp.Name, MaxScoreEmp.Surname, maxScore);
