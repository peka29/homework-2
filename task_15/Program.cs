// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число, соответствующее дню недели: ");
int dayNamber = Convert.ToInt32(Console.ReadLine());

if(dayNamber == 6)
    Console.WriteLine("yes");
if(dayNamber == 7)
    Console.WriteLine("yes");
if (dayNamber == 1)
    Console.WriteLine("no");
if (dayNamber == 2)
    Console.WriteLine("no");
if (dayNamber == 3)
    Console.WriteLine("no");
if (dayNamber == 4)
    Console.WriteLine("no");
if (dayNamber == 5)
    Console.WriteLine("no");
if (dayNamber > 7)
    Console.WriteLine("Введенное число не соответствует дню недели");
