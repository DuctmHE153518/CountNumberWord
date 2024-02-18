using System;
using System.Collections.Generic;

class Program
{
    static int CountWords(string input)
    {
        HashSet<string> vietnameseLetter = new HashSet<string> { "aw", "aa", "dd", "ee", "oo", "ow", "w" };

        int count = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (vietnameseLetter.Contains(input.Substring(i, 2)))
            {
                count++;
                i++; // Bỏ qua ký tự tiếp theo
            }
            else if (vietnameseLetter.Contains(input[i].ToString()))
            {
                count++; // Nếu ký tự hiện tại đơn là chữ cái Tiếng Việt, tăng biến đếm lên 1
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Input: ");
        string inputStr = Console.ReadLine();

        int result = CountWords(inputStr);
        Console.WriteLine($"Output: {result}");
    }
}
