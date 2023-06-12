using System.Reflection;

Console.WriteLine("Ввведите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввведите m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] mas = new int[n, m+1];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("mas[" + i + "," + j + "]: ");
        mas[i, j] = int.Parse(Console.ReadLine());
    }

}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mas[i, m] += (mas[i, j]);
        mas[i, m] = Math.Abs(mas[i, m]);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = i+1; j < n; j++)
    {
        if (mas[j,m] > mas[i,m])
        {
            for (int k = 0; k < m; k++)
            {
                int tmp = mas[i, k];
                mas[i, k] = mas[j, k];
                mas[j, k] = tmp;
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
