// Задача 1: Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше;

System.Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    System.Console.WriteLine($"max = {num1}");
    System.Console.WriteLine($"min = {num2}");
}
else 
{
    System.Console.WriteLine($"max = {num2}");
    System.Console.WriteLine($"min = {num1}");
}