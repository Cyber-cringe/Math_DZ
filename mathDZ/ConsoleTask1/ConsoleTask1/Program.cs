﻿using System;
double min = 1000000000000;
for (int i = 0; i < 3; i++)
{
    if (numbers[i] <= min)
    {
        min = numbers[i];
    }
}
Console.WriteLine("Минимум:" + min);