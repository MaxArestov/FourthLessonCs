// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120
Console.Clear();
Console.WriteLine("Введите число: ");
bool checkDigit = int.TryParse(Console.ReadLine(), out int n);
if (!checkDigit)
{
    Console.WriteLine("Введены некорректные данные: ");
    return;
}
if (n < 1)
{
    Console.WriteLine("-0");
}
Console.WriteLine($"Произведение чисел от 1 до N равно {GetDigitPlenty(n)}");





int GetDigitPlenty(int number)
{
    int plenty = 1;
    for (int i = 1; i <= number; i++)
    {
        plenty *= i;
    }
    return plenty;
}