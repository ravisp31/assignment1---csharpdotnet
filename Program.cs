using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to reverse a string using for loop.
            String s = "dotnetdeveloper";

            for(int i =s.Length-1; i>=0; i--)
            {
                Console.WriteLine(s[i]);
            }

            // Write a C# program to check whether a string is palindrome or not.
            string Name = "madam";
            string rev = "";

            for(int i = Name.Length - 1; i >= 0; i--)
            {
                rev += Name[i];
            }
            if(Name == rev)
            {
                Console.WriteLine("The string is palindrome:"+Name);
            }
            else
            {
                Console.WriteLine("The string is not palindrome:"+Name);
            }

            // Write a C# program to reverse the words in a given string.
            string str = "I am a dotnet developer";
            string[] words = str.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            //write a C# program to reverse each word in a given string.
            string DEPt = "BE Computer Science and design";
            string[] CLG = DEPt.Split(' ');

            foreach (string w in CLG)
            {
                
                for (int i = w.Length - 1; i >= 0; i--)
                {
                    Console.Write(w[i]);
                }

                Console.Write(" "); 
            }
            //write a C# program to count the number of occurrences of each character in a string.
            string stack = "king of DOTNET";

            for (int i = 0; i < stack.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < stack.Length; j++)
                {
                    if (stack[i] == stack[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine(stack[i] + " = " + count);
            }

            //write a C# program to remove duplicate characters from a string.
            string lang = "programming";
            string result = "";

            foreach (char ch in lang)
            {
                if (!result.Contains(ch))
                {
                    result = result + ch;
                }
            }

            Console.WriteLine(result);
            //
            string don = "ravi";

            for (int i = 0; i < don.Length; i++)
            {
                for (int j = i; j < don.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(don[k]);
                    }

                    Console.WriteLine();
                }
            }







        }
    }
}
