Console.WriteLine("Ввведите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввведите m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] mas = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("mas[" + i + "," + j + "]: ");
        mas[i, j] = int.Parse(Console.ReadLine());
    }
}

int minimus = 0;
int mini = 0;
int minj = 0;
bool win = false;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (mas[i, j] < minimus)
        {
            minimus = mas[i, j];
            minj = j;
            mini = i;
            win = true;
            break;
        }

    }
    if (win == true)
    {
        break;
    }
}
int maximus = -1;
int maxi = 0;
int maxj = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (mas[i, j] > 0)
        {
            maximus = mas[i, j];
            maxj = j;
            maxi = i;
        }
    }
}

Console.Write(minimus + " координаты первого отрицательного: " + mini + " " + minj);
Console.WriteLine();
Console.Write(maximus + " координаты последнего положительного: " + maxi + " " + maxj);