//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Напишите день недели цифрой: ");
int num = int.Parse(Console.ReadLine());

if (num > 5 && num < 8)
    Console.WriteLine("Выходной");
if (num < 6 && num > 0)
    Console.WriteLine("Будний");
if (num > 7)
    Console.WriteLine("Такого дня недели нет");

