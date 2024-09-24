using ChallengeApp;

Console.WriteLine("Witamy w Programie do oceny pracowników!");
Console.WriteLine();

EmployeeInMemory employee = new EmployeeInMemory("Adam", "Adam");
employee.AddGrade(50);

EmployeeInFile employee1 = new EmployeeInFile("Miky", "Mike");

Console.Write("Podaj pierwszą ocenę pracownika. Użyj dowolnej liczby 0-100 albo litery A-E. Aby zatwierdzić, naciśnij Enter: ");
var input = Console.ReadLine();

try
{
    employee1.AddGrade(input);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine();

while(true)
{
    Console.Write("Podaj kolejną ocenę pracownika. Użyj dowolnej liczby 0-100 albo litery A-E.");
    Console.Write("Aby zatwierdzić, naciśnij Enter. Aby zakończyć wpisywanie ocen, naciśnij Spacja + Enter: ");
    input = Console.ReadLine();

    if (input == " ")
    {
        break;
    }

    try
    {
        employee1.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

var statistics = employee1.GetStatistics();
Console.WriteLine($"Minimalna ocena: {statistics.Min:N2}");
Console.WriteLine($"Maksymalna ocena: {statistics.Max:N2}");
Console.WriteLine($"Średnia ocena: {statistics.Average:N2}");
Console.WriteLine($"Średnia ocena: {statistics.AverageLetter:N2}");