// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 4 -> 10 8 -> 36
Console.Clear();
bool isParsed = int.TryParse(Console.ReadLine(), out int a);
if (!isParsed)
{
    Console.WriteLine("Введены некорректные данные.");
}
int sum = GetSumNumbers(a);
Console.WriteLine(sum);
int GetSumNumbers(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}