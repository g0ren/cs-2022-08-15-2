using System;
using System.Text.RegularExpressions;
public class Solution
{
    public string Interpret(string command)
    {
        command = Regex.Replace(command, Regex.Escape("(") + Regex.Escape(")"), "o");
        command = Regex.Replace(command, Regex.Escape("(") + "al" + Regex.Escape(")"), "al");
        return command;
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        var command = Console.ReadLine();
        Solution s = new Solution();
        Console.WriteLine(s.Interpret(command));
    }
}