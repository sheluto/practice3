// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()??"0");
int result1 = number/10;
int result2 = result1%10;
Console.WriteLine($"{result2}");
