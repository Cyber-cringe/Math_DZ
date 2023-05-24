using System.Diagnostics;

Console.WriteLine("Введите a, b, step");
string[] values = Console.ReadLine().Split(' ');

double a = Convert.ToDouble(values[0]);
double b = Convert.ToDouble(values[1]);
double step = Convert.ToDouble(values[2]);

double result = 0;
double sh(double x)
{
    double res = 0;
    res = ((Math.Exp(x)) - (Math.Exp(-x)))/2;
    return res;
}

for (double i = a; i <= b; i += step)
{
    result = Math.Sin(i) * sh(i);
    Console.Write($"{i}\n"); 
    Console.Write($"{result}\n");
}