// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Какое количество чисел Вы хотите ввести: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] Numbers(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] array = Numbers(numbers);

Console.WriteLine($"Вы ввели {Count(array)} чисел больше нуля");