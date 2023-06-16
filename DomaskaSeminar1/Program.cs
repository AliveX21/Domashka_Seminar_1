/* Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое целое число:");
int num_a = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число:");
int num_b = int.Parse(Console.ReadLine());

if (num_a > num_b)
{
    Console.WriteLine("Первое число больше чем второе");
}

else 
{
    Console.WriteLine("Первое число меньше чем второе");
}
