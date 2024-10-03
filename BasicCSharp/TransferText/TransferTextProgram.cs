using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.TransferText
{
    public class TransferTextProgram
    {
        public void Main()
        {
            string word;
            char[] arrayCharactersOfWord;

            Console.Write("Enter a string: ");
            word = Console.ReadLine();

            arrayCharactersOfWord = word.ToCharArray(0, word.Length); // Transfer string to array of characters.  

            Console.Write("After transferring, we have a string: ");
            for (int i = 0; i < word.Length; i++)
            {
                TransferCharacter(arrayCharactersOfWord[i]);
            }

            Console.Write("\n\n");
            Console.ReadKey();
        }

        /// <summary>
        /// Transfer a character between being lower and being upper
        /// </summary>
        /// <param name="character">character</param>
        public void TransferCharacter(char character)
        {
            if (Char.IsLower(character))
            {
                Console.Write(Char.ToUpper(character));
            }
            else
            {
                Console.Write(Char.ToLower(character));
            }
        }
    }
}
