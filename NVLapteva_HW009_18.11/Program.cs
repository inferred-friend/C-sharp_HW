// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите первое число точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DisPoint (int x1, int y1, int z1, int x2, int y2, int z2)
{
double leg1 = Math.Pow((x2-x1), 2);
double leg2 = Math.Pow((y2-y1), 2);
double leg3 = Math.Pow((z2-z1), 2);
double result = Math.Sqrt(leg1+leg2+leg3);
return result;
}
double dispoint = DisPoint (x1, y1, z1, x2, y2, z2);
double pointRound = Math.Round(dispoint, 2, MidpointRounding.ToZero);
Console.WriteLine(pointRound);