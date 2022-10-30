/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1  */

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int numberB = number / 10;  // 456/
int numberA = number % 100; // 456%100=4
int numberC = number / 10;  // 456%10 =6
Console.WriteLine($"Второе число от {number} это {numberB % 10}");
