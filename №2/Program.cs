using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №2.\nВвести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.\nЗнаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра.");
            Console.WriteLine("\nУ вас 10 попыток, удачи!");
            int o = 1;
            while (o < 11)
            {
                Console.WriteLine("\n\nПопытка №{0} из 10!", o);
                Console.WriteLine("Введите с клавиатуры предложение.(без знаков припинания):\n\n");



                String str1 = Console.ReadLine();
                String str2 = "";
                str1 = str1.Replace(" ", "");
                str1 = str1.ToLower();
                foreach (char c in str1)
                {
                    str2 = c + str2;
                }
                if (str1 == str2)
                {
                    Console.WriteLine("\nСтрока является палиндромом");
                }
                else
                {
                    Console.WriteLine("\nСтрока не является палиндромом");
                }




                o++;
                Console.WriteLine(" ");
                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadKey();
            }

            Console.WriteLine(" ");
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
