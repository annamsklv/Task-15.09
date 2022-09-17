// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
var input = Console.ReadLine();
int number = Int32.Parse(input);


if(number%2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
