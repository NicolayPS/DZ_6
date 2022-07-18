using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1.\nВвести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.\nЗнаки препинания не используются. Найти самое длинное слово в строке.");
            Console.WriteLine("\nУ вас 10 попыток, удачи!");
            int o = 1;
            while (o < 11)
            {
                Console.WriteLine("\n\nПопытка №{0} из 10!", o);
                Console.WriteLine("Введите с клавиатуры предложение.(без знаков припинания):\n");



                string str = Console.ReadLine();
                string[] strArray=str.Split();
                string max = strArray[0];
                foreach(string s in strArray)
                {
                   if (s.Length >max.Length)
                    {
                        max = s;
                    }
                }
                Console.WriteLine(max);
                


                
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
