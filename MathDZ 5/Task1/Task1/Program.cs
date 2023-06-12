Console.WriteLine("Ввведите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввведите m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] mas = new int[n+1, m];
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write("mas[" + i + "," + j + "]: ");
        mas[i, j] = int.Parse(Console.ReadLine());
    }
}

bool fin = false;
int last = n - 1;
for (int i = 0; i < n; i++)
{
    if (last <= i)
    {
        fin = true;
        break;
    }
    else
    {
        for (int j = 0; j < m; j++)
        {
            mas[n, j] = mas[last, j];
        }
        for (int j = 0; j < m; j++)
        {
            mas[last, j] = mas[i, j];
        }
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = mas[n, j];
        }
        last--;
    }
    if (fin) break;
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mas[j, i]);
        Console.Write(' ');
    }
    Console.Write("tmp -->");
    Console.Write(mas[n, i]);
    Console.WriteLine();
}