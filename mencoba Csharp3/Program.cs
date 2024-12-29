using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mencoba_Csharp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kata = { "aku", "makan", "minum", "tidur" };
            foreach (string s in kata)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
            Console.WriteLine($"panjang dari list : {kata.Length}");

            // ini list
            List<string> kata3 = new List<string>();
            kata3.Add("ahmad");
            kata3.Add("jaja");
            Console.WriteLine(kata3.Contains("jaja"));
            Console.WriteLine(kata3.Count());          
            foreach (string s in kata3)
            { 
                Console.WriteLine(s);
            }





        }
    }
}
