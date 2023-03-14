// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите трехзначное число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = (n1 / 10);
int n3 = (n2 % 10);

if(n1 < 100 || n1 > 999)
    Console.WriteLine("Вы ввели не трехзначное число");
else
    Console.WriteLine(n3);
