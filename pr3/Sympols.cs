using System;
using System.Collections.Generic;
using System.Text;

namespace pr3
{
    internal class Symbols
    {
        private static readonly char[] _sentence = {'?', '!', '.'};
        private static readonly char[] _words = { ',', ' ', '(', ')', ':', ';', '?', '!', '.'};
        private static readonly string _vowels = "аеёиоуыэюя";


        public static string[] Sentence(string text)
        {
            return text.Split(_sentence, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }
        public static string[] Wrods(string text)
        {
            return text.Split(_words, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }
        public static bool Vowels(char text)
        {
            return _vowels.Contains(char.ToLower(text));
        }


    }
}
