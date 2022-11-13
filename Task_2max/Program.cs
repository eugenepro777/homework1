// найти максимальное из 2х чисел и вывести на экран его значение

Console.WriteLine("Введите два числа: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > numberA)
    Console.WriteLine("max = " + numberB);
    else
    if (numberB == numberA)
    Console.WriteLine("Два числа одинаковы");
else
    Console.WriteLine("max = " + numberA);