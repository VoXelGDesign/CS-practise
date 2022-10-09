using System;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Regex regex = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
        string testEmail = "test23.12@gmail.com";
        Console.WriteLine(regex.IsMatch(testEmail));

    }
}