using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60 };  // 6 numbers

        Console.WriteLine("Length = " + numbers.Length);

        var index = Array.IndexOf(numbers, 30);
        Console.WriteLine("Index of 30:" + index);

        Array.Clear (numbers, 0,3);
        Console.WriteLine("Effect of clear()");
        foreach (int n in numbers) 
        Console.WriteLine(n);
        

    }
}
