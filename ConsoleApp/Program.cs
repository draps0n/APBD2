﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello,, World PL!!");;
Console.WriteLine(GetAvg([1, 2, 3, 4, 5]));
Console.WriteLine(GetMax([1, 2, 3, 4, 5]));

static double GetAvg(int[] arr)
{
    int dodawanko = 0;

    foreach (int i in arr)
    {
        dodawanko += i;
    }

    return (double) dodawanko / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = arr[0];

    foreach (int i in arr)
    {
        if (i > max)
            max = i;
    }

    return max;
}