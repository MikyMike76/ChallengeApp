int number = 4566;
string numberToString = number.ToString();
char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] repeats = new int[10];
foreach (char c in numberToString)
{
    for (int i = 0; i < digits.Length; i++)
    {
        if(c == digits[i])
        {
            repeats[i]++;
        }
    }
}

for (int i = 0; i < digits.Length; i ++)
{
    Console.WriteLine("Cyfra {0} wystąpiła {1} razy", digits[i], repeats[i]);
}

