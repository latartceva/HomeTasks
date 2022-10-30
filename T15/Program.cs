/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет  

*/
Console.WriteLine("Введите число - ");
string userNumber = Console.ReadLine();
int dayNumber = int.Parse(userNumber);
if (dayNumber == 1 ||dayNumber == 2 || dayNumber == 3 || dayNumber == 4||dayNumber == 5) 
Console.WriteLine("нет, этот день не выходной");
if (dayNumber == 6 ||dayNumber == 7) Console.WriteLine("да, этот день выходной");
