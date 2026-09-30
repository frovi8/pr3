using System;

namespace pr3
{
    
    internal class Program
    {
        static string text = "";
        static string Text()
        {
            while (true)
            {
                text = 
                    """
                    По реке плывет кораблик. 
                    Он плывет издалека. 
                    На кораблике четыре 
                    Очень храбрых моряка. 
                    У них ушки на макушке, 
                    У них длинные хвосты, 
                    И страшны им только кошки, 
                    Только кошки да коты
                    """;

                if (text.Trim().Length >= 100)
                {
                    return text;
                }
                else
                {
                    Console.WriteLine("Количество символов < 100");
                }
            }
        }      

        static void Main(string[] args)
        {
            Text();
            Print();
        }
        static void Print()
        {
            var (v, c) = VowelsAndConsonants();
            Console.WriteLine($"Количество слов: {WordCount()}");
            Console.WriteLine($"Самое короткое слово: {MinWord()}");
            Console.WriteLine($"Количество предложений: {Sentence()}");
            Console.WriteLine($"Количество гласных: {v}, количество согласных: {c}");
            Console.WriteLine($"Самое длинное слово: {MaxWord()}");

        }
        static int WordCount()
        {
            string[] splitText = Symbols.Wrods(text);

            return splitText.Length;
        }

        static string MinWord()
        {
            string[] splitText = Symbols.Wrods(text);

            string min = splitText[0];

            for (int i = 1; i < splitText.Length; i++) 
            {
                if (splitText[i].Length < min.Length)
                {
                    min = splitText[i];
                }
            }
            return min;
        }

        static string MaxWord()
        {
            string[] splitText = Symbols.Wrods(text);

            string max = splitText[0];

            for (int i = 1; i < splitText.Length; i++)
            {
                if (splitText[i].Length > max.Length)
                {
                    max = splitText[i];
                }
            }
            return max;
        }

        static int Sentence()
        {
            string[] splitText = Symbols.Sentence(text);

            return splitText.Length;
        }

        static (int countVowels, int countConsonants) VowelsAndConsonants()
        {
            int countVowels = 0;
            int countConsonants = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Symbols.Vowels(text[i]) == true)
                {                    
                    countVowels++;
                }
                else if (Symbols.Vowels(text[i]) == false && char.IsLetter(text[i]) && text[i] != 'ь' && text[i] != 'ъ') 
                {
                    countConsonants++;
                }
            }
            return (countVowels, countConsonants);
        }
    }
}
