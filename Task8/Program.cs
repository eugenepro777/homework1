// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberFirst = 1;
int numberSecond = numberFirst + 1;
int numberLast = numberN + 1;

if (numberN < 1)
{
    Console.WriteLine($"Число меньше {numberFirst}, повторите ввод");
}
else
{
while (numberLast > numberSecond && numberLast >= numberN)
{
    Console.Write($"{numberSecond} ");
    numberSecond += 2;
}
}