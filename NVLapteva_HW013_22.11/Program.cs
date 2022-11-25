// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void RandomArray(int[] array)
{
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num.Next(0, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

RandomArray(array);

PrintArray(array);