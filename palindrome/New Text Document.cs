using System;
namespace palindromecheck {
   class Program {
      static void Main(string[] args) {
          string string1, rev;
          Console.Write("Enter the string: ");   
          string1 = Console.ReadLine();
         char[] ch = string1.ToCharArray();
         Array.Reverse(ch);
         rev = new string(ch);
         bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
         if (b == true) {
            Console.WriteLine("true");
         } else {
            Console.WriteLine("false");
         }
         Console.Read();
      }
   }
}