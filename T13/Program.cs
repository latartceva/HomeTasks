/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("ВВедите число");
string number = Console.ReadLine();
int num = Math.Abs(int.Parse(number));
int count = 0;
while(num > 999)
{
    num = num / 10;
    count++; 
}
if(num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"третья цифра числа {number}-это {num = num % 10}");
}
