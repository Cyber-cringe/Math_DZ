Console.WriteLine("Ввведите лимит");
double limit = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ввведите x");
double x = Convert.ToDouble(Console.ReadLine());

double lastnumer = x*x;
double lastdenom = 1;
double res = lastnumer / lastdenom;

int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}


for (int i = 1; i < 10; i++)
{
    double numerator = Math.Pow(lastnumer, (2*i - 1));
    double denominator = Factorial((2*i)-1);
    res += numerator / denominator;

    if (Math.Abs(res) < limit) { break; }
    lastnumer = numerator;


}

Console.WriteLine("Результат: " + res);