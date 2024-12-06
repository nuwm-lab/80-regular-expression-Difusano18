using System;
using System.Text.RegularExpressions;

namespace RegularExpressionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заданий текст
            Console.WriteLine("Введіть текст:");
            string inputText = Console.ReadLine();

            // Регулярний вираз для пошуку тегів <html>, <form>, <h1>
            string pattern = @"<(html|form|h1)>";

            // Створення об'єкта Regex
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            // Пошук збігів у тексті
            MatchCollection matches = regex.Matches(inputText);

            // Виведення результатів
            if (matches.Count > 0)
            {
                Console.WriteLine($"Знайдено {matches.Count} HTML теги:");
                foreach (Match match in matches)
                {
                    Console.WriteLine($"- {match.Value}");
                }
            }
            else
            {
                Console.WriteLine("HTML теги не знайдено.");
            }
        }
    }
}
