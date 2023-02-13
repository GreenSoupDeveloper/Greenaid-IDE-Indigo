using System;
using System.IO;
namespace Example
{
   public class Program
   {
       //this is a calculator made in Greenaid IDE Indigo!, it works and it can calculate 32 bit numbers
       public static string num1;
       public static string num2;
       public static string res;
       static void Main(string[] args)
       {
           Console.WriteLine("Type a number:");
           num1 = Console.ReadLine();
           Console.WriteLine("Type the enumerator (/,+,*,-)");
           res = Console.ReadLine();
           Console.WriteLine("Type another number:");
           num2 = Console.ReadLine();
          

           if(res == "+")
           {
                var numsec1 = Int32.Parse(num1);
                var numsec2 = Int32.Parse(num2);
                Console.WriteLine(numsec1 + numsec2);

  
           }
           if(res == "*")
           {
                var numsec1 = Int32.Parse(num1);
                var numsec2 = Int32.Parse(num2);
                Console.WriteLine(numsec1 * numsec2);

  
           }
           if(res == "/")
           {
                var numsec1 = Int32.Parse(num1);
                var numsec2 = Int32.Parse(num2);
                Console.WriteLine(numsec1 / numsec2);

  
           }
           if(res == "-")
           {
                var numsec1 = Int32.Parse(num1);
                var numsec2 = Int32.Parse(num2);
                Console.WriteLine(numsec1 - numsec2);

  
           }
           var cont = Console.ReadLine();
       }
   }


















}