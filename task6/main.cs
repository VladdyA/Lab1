using System;
class main

{
    enum HTTPError
    {
        Bad_Request = 400,
        Unauthorized,
        Payment_Required,
        Forbidden,
        Not_Found

    }

    static void Main()
    {
        Console.WriteLine("Task 1");
        float a;
        float b;
        float c;
        a = Convert.ToSingle(Console.ReadLine());
        b = Convert.ToSingle(Console.ReadLine());
        c = Convert.ToSingle(Console.ReadLine());

        string result1 = (a >= -5) && (a <= 5) ? "Перше число належить цьому дiапазону" : "Перше число не належить цьому дiапазону";
        string result2 = (b >= -5) && (b <= 5) ? "Друге число належить цьому дiапазону" : "Друге число не належить цьому дiапазону";
        string result3 = (c >= -5) && (c <= 5) ? "Третє число належить цьому дiапазону" : "Третє число не належить цьому дiапазону";

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);

        Console.WriteLine("Task 2");
        int d, e, f;
        Console.WriteLine("Введiть перше число");
        d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введiть друге число");
        e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введiть третє число");
        f = Convert.ToInt32(Console.ReadLine());

        int[] arr = { d, e, f };
        Console.WriteLine("Мiнiмальне число" + arr.Min());
        Console.WriteLine("Максимальне число" + arr.Max());



        Console.WriteLine("Task 3");
        int errCode;
        errCode = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((HTTPError)errCode);
        Console.ReadKey();
        Console.ReadLine();
       
    }

}
