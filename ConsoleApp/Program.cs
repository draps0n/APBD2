// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello,, World PL!!");;
Console.WriteLine(GetAvg([1, 2, 3, 4, 5]));

static double GetAvg(int[] arr)
{
    int sum = 0;

    foreach (int i in arr)
    {
        sum += i;
    }

    return (double) sum / arr.Length;
}