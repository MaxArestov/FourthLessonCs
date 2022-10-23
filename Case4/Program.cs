// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
int[] a = new int[8];
FillArray(a);
PrintArray(a);



void FillArray(int[] array)
{
        int index = 0;
    Random random = new Random();
    while(index < array.Length)
    {
        array[index] = random.Next(0, 2);
        index++;
    }
}

void PrintArray(int[] mass)
{
    int count = 0;
    Console.WriteLine("Элементы массива: ");
    while (count < mass.Length)
    {
        Console.Write($"{mass[count]} ");
        count++;
    }
}