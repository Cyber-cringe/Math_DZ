using System;using System.Linq;double[] numbers = {-2, 5, 0};
double min = 1000000000000;
for (int i = 0; i < 3; i++)
{
    if (numbers[i] <= min)
    {
        min = numbers[i];
    }
}
Console.WriteLine("Минимум:" + min);