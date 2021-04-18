using System;
using System.Collections;

static void Main(string[] args)
{
    var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
    Console.WriteLine(tuple.count);
    Console.WriteLine(tuple.sum);

    Console.Read();
}

static (int sum, int count) GetNamedValues(int[] numbers)
{
    var result = (sum: 0, count: 0);
    for (int i = 0; i < numbers.Length; i++)
    {
        result.sum += numbers[i];
        result.count++;
    }
    return result;
}
