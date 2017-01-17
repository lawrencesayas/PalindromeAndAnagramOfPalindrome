using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeAndAnagramOfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a text: ");
            string text = Console.ReadLine();

            Word word = new Word(text);
            word.IdentifyClassificationOfWord();
            Console.WriteLine(word.Classification);

            Console.ReadLine();
        }
    }

    public enum classification { Palindrome, Anagram, Neither }

    public class Word
    {
        public string InputString { get; set; }
        public classification Classification { get; set; }

        public Word(string inputString)
        {
            this.InputString = inputString;
        }

        public bool IdentifyClassificationOfWord()
        {
            if (IsPalindrome(0, this.InputString.Length - 1, this.InputString.ToCharArray()) || IsAnagram())
                return true;
            else
            {
                this.Classification = classification.Neither;
                return false;
            }
        }

        private bool IsAnagram()
        {
            //Counts the number of distinct characters
            var charCount = this.InputString.GroupBy(c => c, (c, i) => new
            {
                character = c,
                count = i.Count()
            });

            //Checks how many distinct characters are odd in qty
            if (charCount.Count(c => c.count % 2 == 1) <= 1)
            {
                this.Classification = classification.Anagram;
                return true;
            }
            else
                return false;
        }

        //Recursion checking whether a word is a palindrome
        private bool IsPalindrome(int left, int right, char[] inputString)
        {
            //When checking reaches the center of the word the word is then a Palidrome
            if (left == right || left > right)
            {
                this.Classification = classification.Palindrome;
                return true;
            }
            //Checks the equality of the left and right side of the word
            if (inputString[left] == inputString[right])
                return IsPalindrome(++left, --right, inputString);
            else
                return false;
        }
    }
}
