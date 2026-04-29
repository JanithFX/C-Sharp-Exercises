using System;

public class Program
{
    public static void Main(string[] args)
    {
        Class2 obj1 = new Class2(10, 20);

        int total = obj1.add();

        Console.WriteLine("The total is: " + total);
    }
}