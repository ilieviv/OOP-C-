﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class RandomCommercialMessage
    {

        private static string[] PraisingPhrases = new string[]
        {
                    "Продуктът е отличен.",
        "Това е страхотен продукт.",
        "Постоянно ползвам този продукт.",
        "Това е най-добрият продукт от тази категория."

        };

        private static string[] PraisingEvents = new string[]
        {
            "Вече се чувствам добре.",
        "Успях да се променя.",
        "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно.",
        "Опитайте и вие. Аз съм много доволна."

        };

        private static string[] AuthorsFirstName = new string[] { "Диана", "Петя", "Стела", "Елена", "Катя" };

        private static string[] AuthorsLastName = new string[] { "Иванова", "Петрова", "Кирова" };

        private static string[] AuthorsCity = new string[] { "София", "Пловдив", "Варна", "Русе", "Бургас" };

        private static Random rnd = new Random();
        private static string GenerateString(string[] availableStrings)
        {
            int randomIndex = rnd.Next(availableStrings.Length);
            string randomString = availableStrings[randomIndex];
            return randomString;
        }

        static void Main(string[] args)
        {
            StringBuilder CommercialMessage = new StringBuilder();
            string Phrase = GenerateString(PraisingPhrases);
            CommercialMessage.Append(Phrase + " ");
            string Event = GenerateString(PraisingEvents);
            CommercialMessage.Append(Event + " ");
            string FirstName = GenerateString(AuthorsFirstName);
            string LastName = GenerateString(AuthorsLastName);
            string City = GenerateString(AuthorsCity);
            CommercialMessage.Append(" -- " + FirstName + " " + LastName + ", " + City);
            string finalMessage = CommercialMessage.ToString();
            Console.WriteLine(finalMessage);


        }
    }
}
