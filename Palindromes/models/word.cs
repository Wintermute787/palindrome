using System;
namespace Palindromes
{
    class Word
    {
        private string UserWord;
        private string revUser;

        public Word(string word, string rev)
        {
            UserWord = word;
            revUser = rev;

        }

        public bool IsPal(string word, string revWord)
        {
            return (word == revWord);
        }
    }
}
