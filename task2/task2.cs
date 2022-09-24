using System;
class task2

{
    static void Main()
    {
        double a;
        a = Convert.ToDouble(Console.ReadLine());
        var x1 = (a * 10) % 10;
        var x2 = (a * 100) % 10;
        int result = (int)(x1 + x2);
        Console.WriteLine(result);

    }

}