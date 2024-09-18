using ChallengeApp;

Employee employee1 = new Employee("Miky", "Mike");
employee1.AddGrade(5.5f);
employee1.AddGrade(6.3f);
employee1.AddGrade(7);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Minimalna ocena: {statistics.Min:N2}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max:N2}");
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");