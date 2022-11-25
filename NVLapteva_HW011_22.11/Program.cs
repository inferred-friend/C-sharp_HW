// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Involution(int number_a, int number_b)
{
    int result = 1;
    for (int i = 1; i <= number_b; i++)
    {
        result = number_a * result;
    }
    return result;
}
if (b > 0)
{
int involution = Involution(a, b);
Console.WriteLine($"Число {a} в степени {b} = {involution}");
}

else Console.WriteLine("Вы ввели неверные данные. Введите число: ");