using System;

namespace Lesson_4
{
    class Program
    {
        static void Task_1()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Task_2()
        {
            int r = 7;
            int i = 0;
            int j = 0;

            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        private static int IndexOf(char[] array, char letter)
        {
            for (int i = 0; i <26; i++)
            {
                if (array[i] == letter)
                {
                    return i;
                }
            }
            return 1;
        }

        static string Encode(string word)
        {
            string encodedWord = "";
            char[] alphabetArray = { 'a', 'b', 'c', 'd' };
            /*for (int i = 0; i < 26; i++)
            { 
                alphabetArray[i] = (char)(i + (int)('A'));
            }
            */
            char[] encodedArray = { 'x', 'w', 'z', 'y', 'c' };
            char letter;
            int index = 0;
            for (int i = 0; i < word.Length; i++)
            {
                letter = word[i];
                index =IndexOf(alphabetArray, letter);
                encodedWord += encodedArray[index]; 
            }
            return encodedWord;
        }
        static void Task_3()
        {
            Console.WriteLine("What is your word ?");
            string word = Convert.ToString(Console.ReadLine());
            string encodedWord = Encode(word);
            Console.WriteLine("Your encoded word is " + encodedWord);
        }
        static void Main()
        {
            Task_3();
        }
    }
}
