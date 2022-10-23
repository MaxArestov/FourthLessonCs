// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3 78 -> 2 89126 -> 5


Console.Clear();
Console.WriteLine("Введите число: ");
bool checkDigit = int.TryParse(Console.ReadLine(), out int a);
if (!checkDigit)
{
    Console.WriteLine("Введены некорректные данные: ");
    return;
}
Console.WriteLine(DigitCount(a));


int DigitCount(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
