using System;
using System.Collections.Generic;

public class EvenOddStack
{
    public static void Main()
    {
        Stack<int> evenStack = new Stack<int>();
        Stack<int> oddStack = new Stack<int>();

        Console.WriteLine("Введите числа (для завершения введите пустую строку):");
        string input = null;
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

        Stack<int> sortedStack = new Stack<int>();
        while (evenStack.Count > 0)
        {
            sortedStack.Push(evenStack.Pop());
        }
        while (oddStack.Count > 0)
        {
            sortedStack.Push(oddStack.Pop());
        }

        Console.WriteLine("Отсортированные числа:");
        while (sortedStack.Count > 0)
        {
            Console.WriteLine(sortedStack.Pop());
        }
    }
}