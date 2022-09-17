// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");        //Эти две строчки сжаты в одну:
int N = Int32.Parse(Console.ReadLine());   //var input = Console.ReadLine();
                                           //int N = Int32.Parse(input);              

int CurrentNumber = 1;

while(CurrentNumber <= N)
{
    if(CurrentNumber % 2 == 0)
{
    Console.Write(CurrentNumber);
    Console.Write(", ");    //не понимаю, как добавить запятую другим способом и как при этом способе убрать запятую после последнего числа в ряду
}
else
{    
}
CurrentNumber++; // то же самое, что CurrentNumber = CurrentNumber + 1
}
