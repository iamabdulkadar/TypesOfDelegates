using System;

namespace PredicateDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var predicate = new Predicate<char>(IsVowel);
            GetLetter(predicate);
        }

        static void GetLetter(Predicate<char> vowel)
        {
            Console.WriteLine(vowel('a'));
            Console.WriteLine(vowel('A'));
            Console.WriteLine(vowel('E'));
            Console.WriteLine(vowel('s'));
            Console.WriteLine(vowel('X'));
            Console.WriteLine(vowel('i'));
            Console.WriteLine(vowel('k'));
        }
        static bool IsVowel(char letter)
        {
            bool isVowel = false;
            switch (char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    isVowel = true;
                    break;
                default:
                    break;
            }
            if (isVowel == true)
            {
                return true;
            }
            return false;
        }

    }
}
