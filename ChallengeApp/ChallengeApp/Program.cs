string name;
string answerSex;
bool sex = true;
int age;
Console.Write("Wpisz swoje imię: ");
name = Console.ReadLine();
name = name.ToLower();
Console.WriteLine();
Console.Write("Czy jesteś mężczyzną? Wpisz tak/nie: ");
answerSex =  Console.ReadLine();
answerSex = answerSex.ToLower();
if (answerSex == "tak")
{
    sex = true;
}
else if (answerSex == "nie")
{
    sex = false;
}
else
{
    Console.WriteLine("Wpisałeś złą odpowiedź na 2. pytanie! Zacznij program od nowa i odpowiadaj tylko tak/nie!");
}
Console.WriteLine();
Console.Write("Wpisz swój wiek: ");
age = Convert.ToInt32(Console.ReadLine());

if (age < 30 && sex == false)
{
    Console.WriteLine("Kobieta poniżej 30-ki");
}
else if (name == "ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == true && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna!");
}
else
{
    Console.WriteLine();
}