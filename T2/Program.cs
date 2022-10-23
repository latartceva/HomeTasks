//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 2 числа: ");
string numberAStr = Console.ReadLine();
string numberBStr = Console.ReadLine();
int numberA = int.Parse(numberAStr);
int numberB = int.Parse(numberBStr);

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше {numberB}");
}
else
{
    Console.WriteLine($"Число {numberB} больше {numberA}");
}


