using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_2
{
    class Program
    {
        //Задача2 *. Программно создайте текстовый файл и запишите в него 10 случайных чисел.
        //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
        static void Main(string[] args)
        {
            string s1 = ("target");
            string s2 = ("random.txt");
            string put = Path.GetFullPath(s2);
            string put1 = Path.GetFullPath(s1);
            if (!Directory.Exists(s1))
            {
                Directory.CreateDirectory(s1);

                /*if (File.Exists(put1))
                {
                    File.Create(put1 + @"\" + s2);
                }*/
                //хотел создать файл, а потом уже записывать в него данные. Но StreamWrite сам создвет файл.
                //И если через Create создать файлБ выдает ошибку.
                //Если дадите коммент по данному вопросу, буду благодарен.
            }
            int[] mas = new int[10];
            int sum = 0;
            if (File.Exists(put1 + @"\" + s2))
            {
                using (StreamWriter s = new StreamWriter((put1 + @"\" + s2)))
                {
                    s.Write("");
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                mas[i] = rand.Next(0, 10);
                using (StreamWriter s = new StreamWriter((put1 + @"\" + s2), true))
                {
                    s.Write("{0} ", mas[i]);
                    if (i == 9)
                    {
                        s.WriteLine("{0} ", mas[i]);
                        sum += mas[i];
                        s.WriteLine("Сумма чисел = {0} ", sum);
                        //Console.WriteLine(sum);
                        break;
                    }
                    sum += mas[i];
                }
            }
            using (StreamReader s = new StreamReader((put1 + @"\" + s2), true))
            {
                Console.WriteLine(s.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}

