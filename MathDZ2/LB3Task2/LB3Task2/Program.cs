uint m = 1;
double x = 0;
Console.WriteLine("Введите m: ");
uint.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите x: ");
double.TryParse(Console.ReadLine(), out x);

double LastPow = 1;
uint LastFact = 1;
double res = 1;

for (uint i = 1; i <= m; i++)
{
    double pow = LastPow * x * x * -1;
    LastPow = pow;
    uint fact = LastFact * (2 * i) * (2 * i - 1);
    LastFact = fact;
    res += pow / fact;
}


Console.WriteLine(res);