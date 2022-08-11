//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите первую координату первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());

double x,y;
x=(b2-b1)/(k1-k2);
y=k1*x+b1;

Console.WriteLine("("+x+","+y+")");

