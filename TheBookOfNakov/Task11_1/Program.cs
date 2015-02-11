using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gloriousFr = { "Продуктът е отличен.", "Това е страхотен продукт.", "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория." };
            string[] gloriousEvents = { "Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.", "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна." };
            string[] firstName = { "Диана", "Петя", "Стела", "Елена", "Катя" };
            string[] secondName = { "Иванова", "Петрова", "Кирова" };
            string[] cities = { "София", "Пловдив", "Варна", "Русе", "Бургас" };

            Random random1 = new Random();
            Console.WriteLine("{0}. {1}. {2}. --{3}, {4}", gloriousFr[random1.Next(gloriousFr.Length)], gloriousEvents);

        }
    }
}
