// Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number_1)
{
    int summa = 0;
    while (number_1 > 0)
    {
        summa = summa + number_1 % 10;
        number_1 = number_1 / 10;
    }
    return summa;
}
if (number < 0) number = - number;
int sum = Sum(number);
Console.WriteLine($"Сумма цифр в Вашем числе {number} = {sum}");
