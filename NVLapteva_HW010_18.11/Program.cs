// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int N = -1;
while (N < 1)
{
    Console.WriteLine("Введите любое положительное число: ");
    N = Convert.ToInt32(Console.ReadLine());
    if (N < 1) Console.WriteLine("Вы ввели неверные данные. Повторите ввод данных.");
    
}
void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
       Console.WriteLine($"Куб числа {count} --> {Math.Pow(count, 3)}");
       count++;
    }
}
Cube(N);