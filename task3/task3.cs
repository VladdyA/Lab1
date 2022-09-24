using System;
class task3
{
    static void Main()
    {
        int h;
        h = Convert.ToInt32(Console.ReadLine());
        string result = (h >= 6) && (h <= 12) ? "Доброго ранку!" : (h > 12) && (h < 18) ? "Доброго дня!" : (h >= 18) && (h < 23) ? "Доброго вечора!" : "Доброї ночi!";
        Console.WriteLine(result);
    }
}
