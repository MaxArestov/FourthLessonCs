// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120
Console.Clear();
Console.WriteLine("Введите число: ");
bool checkDigit = int.TryParse(Console.ReadLine(), out int a);
if (!checkDigit)
{
    Console.WriteLine("Введены некорректные данные: ");
    return;
}