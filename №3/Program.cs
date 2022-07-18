using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №3.\nДана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.\nВ строке может быть несколько фрагментов, заключённых в фигурные скобки. \nВозможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.\n");
            Console.WriteLine("\nУ вас 10 попыток, удачи!");
            int o = 1;
            while (o < 11)
            {
                Console.WriteLine("\n\nПопытка №{0} из 10!", o);
                Console.WriteLine("Введите с клавиатуры предложение.:\n\n");



                String str1 = Console.ReadLine();
                String S = str1;
                int i, j, k = 0;
                for (i = 0; i < str1.Length; i++)
                {
                    if (S[i] = "(")
                    {

                    }
                }

                Console.WriteLine(str1);



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
