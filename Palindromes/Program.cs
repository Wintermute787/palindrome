using System;
using System.Collections.Generic;

namespace Palindromes
{
   public  class MainClass
    {
        public static void Main()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Enter a word");
                string myWord = Console.ReadLine();
                char[] charArr = myWord.ToCharArray();
                Array.Reverse(charArr);
                string rev = new string(charArr);
                Word userWord = new Word(myWord, rev);
                Console.WriteLine("-------------");
                Console.WriteLine(myWord);
                Console.WriteLine(rev);
                Console.WriteLine("-------------");
                if (userWord.IsPal(myWord, rev))
                {
                    Console.WriteLine(myWord + " is a palindrome");
                    Console.WriteLine("-------------");
                }
                else
                {
                    Console.WriteLine(myWord + " is NOT  a palindrome");
                    Console.WriteLine("-------------");
                };
                Console.WriteLine("Check Another Word? [Y, N]");
                bool ans = Console.ReadLine().ToUpper() == "N";
                if(ans){
                    i = 1;
                    break;
                };

            }

        }
    }
}
