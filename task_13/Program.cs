// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = ();
int n3 = (n2 % 10);

if(n2 < 100)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(n3);
