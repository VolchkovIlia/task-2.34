using System;
public class MainClass
{
    public static void Main()
    {
        int num1, num2, num3, res1, res2;
        Console.WriteLine("Введите число единиц двузначного слагаемого:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число десятков двузначного слагаемого:");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число однозначного слагаемого:");
        num3 = int.Parse(Console.ReadLine());
        res1 = (num1 + num3) % 10;
        res2 = num2 + (num1 + num3) / 10;
        Console.WriteLine($"Ответ:{res2}{res1}");
    }

}