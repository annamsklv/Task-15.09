// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
var StringA = Console.ReadLine();
int NumberA = Int32.Parse(StringA);

Console.WriteLine("Введите второе число");
var StringB = Console.ReadLine();
int NumberB = Int32.Parse(StringB);
int max = 0;
if(NumberA > NumberB)
{
    max = NumberA;
}
else
{
    max = NumberB;
}
Console.Write("max = ");
Console.WriteLine(max);


