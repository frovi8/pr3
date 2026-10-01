using System;
using System.Security.Cryptography.X509Certificates;

namespace pr3
{
    
    internal class Program
    {
        //static string? text = "";

        static string Text()
        {
            while (true)
            {
                Console.Write("Введите текст (> 100 символов): ");
                string? text = Console.ReadLine();
                Console.WriteLine();

                if (text == "esc")
                {
                    return null;
                }
                
                
                if (text?.Length > 100)
                {
                    return text;
                }
                else
                {
                    Console.WriteLine("Количество символов < 100");
                }
                
            }

            
            //По реке плывет кораблик. Он плывет издалека. На кораблике четыре Очень храбрых моряка. У них ушки на макушке, У них длинные хвосты, И страшны им только кошки, Только кошки да коты

        }
        
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            bool running = true;

            while (running)
            {
                
                Console.WriteLine("Выберите опцию: ");
                Console.WriteLine("Вввести текст - 1");
                Console.WriteLine("Просмотр истории статистики - 2");
                Console.WriteLine("Выход - 0");
                Console.WriteLine();
                Console.Write("Ваш выбор: ");

                string? input = Console.ReadLine();
                Console.Clear();

                    switch (input)
                    {
                        case "1":
                            string ChekText = Text();
                            if (ChekText != null) 
                            { 
                                Print(ChekText); 
                                Console.WriteLine();
                                Console.WriteLine("Нажмите любую клавишу для выхода");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                            }
                            break;
                        case "2":
                            break;
                        case "0":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("sisi");
                            break;
                    }
            }
        }
        static void Print(string text)
        {
            var (v, c) = VowelsAndConsonants(text);
            Console.WriteLine($"Количество слов: {WordCount(text)}");
            Console.WriteLine($"Самое короткое слово: {MinWord(text)}");
            Console.WriteLine($"Количество предложений: {Sentence(text)}");
            Console.WriteLine($"Количество гласных: {v}, количество согласных: {c}");
            Console.WriteLine($"Самое длинное слово: {MaxWord(text)}");

            
            //Console.WriteLine($"Частота встречаемости букв: {Staristic}");


        }
        static int WordCount(string text)
        {
            string[] splitText = Symbols.Wrods(text);

            return splitText.Length;
        }

        static string MinWord(string text)
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

        static string MaxWord(string text)
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

        static int Sentence(string text)
        {
            string[] splitText = Symbols.Sentence(text);

            return splitText.Length;
        }

        static (int countVowels, int countConsonants) VowelsAndConsonants(string text)
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

        static void Staristic(string text)
        {
            var dictionary = new Dictionary<char, int>();            

            var splitText = Symbols.Wrods(text.ToLower().Trim());

            for (int i = 0; i < splitText.Length; i++)
            {
                
            }
        }
    }
}
