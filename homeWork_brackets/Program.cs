using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brackets;
            int countBrackets = 0;
            int bracketDepth = 0;
            bool isErrorInput = false;

            Console.WriteLine("Введите скобки : ");
            brackets = Console.ReadLine();

            for(int i = 0; i < brackets.Length; i++) 
            {
                char breaket = brackets[i];

                if (breaket == ')')
                {
                    countBrackets--;
                }
                else if (breaket == '(')
                {
                    countBrackets++;
                }

                if (countBrackets < 0) 
                {
                    isErrorInput = true;
                    break;
                }

                if (countBrackets > bracketDepth) 
                {
                    bracketDepth = countBrackets;
                }

            }

            if (countBrackets != 0) 
            {
                isErrorInput = true;
            }

            if (isErrorInput == false)
            {
                Console.WriteLine($"Введенная вами скобочная выражение является корректным, а его максимальная глубина скобок {bracketDepth}");
            }
            else 
            {
                Console.WriteLine("Введенная строка не является корректным скобочным выражением");
            }

            Console.ReadKey();                
        }
    }
}
