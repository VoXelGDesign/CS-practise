using System;
using System.Reflection;
using System.Text;


namespace Prjoect_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int? favNum = null; // int or Nullable<int>
            
            Console.WriteLine("Favourite number: " + (favNum.HasValue ? favNum.Value.ToString() : ""));
        }
    }
}