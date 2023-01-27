 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.WriteLine("Напишите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int res = num % 100;
int result = res / 10;

Console.WriteLine($"Второе число цифры {num} будет {result}");