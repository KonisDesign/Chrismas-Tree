using System;
using System.Drawing;

class ChrismasTree
{
    static void Main(string[] arg)
    {
        Console.Write("Size :");
        int size = 6;
        try
        {
            size = int.Parse(Console.ReadLine()) * 2;
        }
        catch
        {
            Console.WriteLine("Please put a number ex: 6");
        }

        int i = 0;
        string[] tree = new string[size];
        Console.ForegroundColor = ConsoleColor.Yellow;
        tree[size - 2] = "*";
        Console.WriteLine(string.Join(" ", tree));

        Console.ForegroundColor = ConsoleColor.Green;

        while (i < size + 1)
        {
            int j = 0;
            while (j < size - i)
            {
                tree[j] = " ";
                j++;
            }
            while (j < i - 1)
            {
                tree[j] = "*";
                j++;
            }

            if (tree[size / 2] != " ")
            {
                Console.WriteLine(string.Join(" ", tree));
            }
            i++;
        }
        Console.ResetColor();
        tree = new string[size];
        tree[size - 2] = "X";
        Console.WriteLine(string.Join(" ", tree));
        tree[size - 2] = "X";
        Console.WriteLine(string.Join(" ", tree));
    }
}
