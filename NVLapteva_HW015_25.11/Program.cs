// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
Console.Write("Массив: ");
int[] array = NewArray(7, -999, 999);
PrintArray(array);

int SumElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 1)
            result += arr[i];
        }
    return result;
}

int sumNumber = SumElements(array);
Console.WriteLine($"Сумма элементов с нечетным индексом = {sumNumber}");