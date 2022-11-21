// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if (amount < 5 || amount > 5) 
{
    Console.WriteLine("Вы ввели неверные данные");
}
else
{
    bool Palindrom()
    {
        int num1 = number % 10;
        int num2 = number % 100 / 10;
        int num3 = number % 1000 / 100;
        int num4 = number % 10000 / 1000;
        int num5 = number / 10000;
        return (num1 == num5 && num2 == num4);
    }
 Console.Write(Palindrom() ? "Это число - палидром" : "Это число - НЕ палидром");
}


