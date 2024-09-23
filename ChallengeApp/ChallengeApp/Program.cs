using ChallengeApp;

Employee employee1 = new Employee("Miky", "Mike");

Console.WriteLine("Witamy w Programie do oceny pracowników!");
Console.WriteLine();
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
    Console.Write("Podaj kolejną ocenę pracownika. Aby zakończyć wpisywanie ocen, naciśnij Spacja + Enter: ");
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