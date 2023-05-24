Console.WriteLine("Введите n");
double n = Convert.ToDouble(Console.ReadLine());
double res = 0;
double tmp = 0;
for (int i = 1; i < n+1; i++)
{
    tmp = 1/(Math.Pow(i, 5));
    res += tmp;
    tmp = 0;
}

Console.WriteLine(res);