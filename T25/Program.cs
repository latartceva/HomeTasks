/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.WriteLine("Ведите два числа  ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
double result = Math.Pow (numberA, numberB);

 Console.WriteLine($"Степень числа {numberA} возведенное в {numberB} = {result}");
