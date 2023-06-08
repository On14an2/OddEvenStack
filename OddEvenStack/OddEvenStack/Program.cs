using System;
using System.Collections.Generic;

public class OddEvenStack
{
    public static void Main()
    {
        Stack<int> evenStack = new Stack<int>();
        Stack<int> oddStack = new Stack<int>();

        Console.WriteLine("Введите числа (для завершения введите пустую строку):");
        string input;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            int number = int.Parse(input);
            if (number % 2 == 0)
            {
                evenStack.Push(number);
            }
            else
            {
                oddStack.Push(number);
            }
        }

        Console.WriteLine("Четные числа:");
        while (evenStack.Count > 0)
        {
            Console.Write(evenStack.Pop() + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Нечетные числа:");
        while (oddStack.Count > 0)
        {
            Console.Write(oddStack.Pop() + " ");
        }
    }
}