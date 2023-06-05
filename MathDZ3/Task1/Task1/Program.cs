Console.WriteLine("Ввведите лимит");
double limit = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввведите x");
double x = Convert.ToDouble(Console.ReadLine());

double lastpow = x * x;
double lastdenomx = lastpow;
double res = lastpow/lastdenomx + 1 ;

for (int i = 2; i < 10; i++)
{
    double numerator = Math.Pow(lastpow, i);
    double denominator = lastdenomx + Math.Pow(i, 3);
    res += numerator / denominator;

    if (Math.Abs(res) < limit) {break;}
    lastpow = numerator;
    lastdenomx = denominator;
}

Console.WriteLine("Результат: " + res);