Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7) Console.WriteLine("Вы ввели неверное число");
else if (day == 6 || day == 7) Console.WriteLine("Выходной день");
else Console.WriteLine("Рабочий день");
