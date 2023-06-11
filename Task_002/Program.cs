// Задача 1: Напишите программу, которая на вход принимает три числа и выдает, максимальное из этих чисел;

System.Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine($"max = {num1}");
}
else if (num1 < num2 && num2 > num3)
{
    System.Console.WriteLine($"max = {num2}");
}
else 
{
    System.Console.WriteLine($"max = {num3}");
}