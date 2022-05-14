using System;

namespace TotalCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] totalCharacters = GetTotalCharacters("Adeola123490");
            foreach (var character in totalCharacters)
            {
                Console.WriteLine(character);
            }
        }

        //This function returns the total number of text characters and the total number of numeric characters
        public static int[] GetTotalCharacters(string s)
        {
            int countInt = 0;
            int countAlphabet = 0;
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                {
                    countInt++;
                }
                else if (char.IsLetter(item))
                {
                    countAlphabet++;
                }
            }

            return new int[] { countInt, countAlphabet };
        }
    }
}
