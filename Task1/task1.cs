using System;
class task1

{
    static void Main()
    {
        int day;
        int month;
        day = Convert.ToInt32(Console.ReadLine());
        month = Convert.ToInt32(Console.ReadLine());
        string result = (day > 0) && (day <= 31) && (month > 0) && (month <= 12) ? "Значення можуть представляти день i мiсяць" : "Значення не можуть представляти день i мiсяць";
        Console.WriteLine(result);
        Console.WriteLine($"{day}, {month}");


    }

}