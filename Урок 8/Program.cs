using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Урок_8
{
    class Program
    {
        //Выберите любую папку на своем компьютере, имеющую вложенные директории.
        //Выведите на консоль ее содержимое и содержимое всех подкаталогов.

        static void Main(string[] args)
        {
            string way = ("C:/Users/Public");
            Console.WriteLine("===Список подкаталагов===");
            string[] dirs = Directory.GetDirectories(way);
            //string[] dirs1 = Directory.GetFiles(way);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
                string[] dirs1 = Directory.GetFiles(s);
                foreach (string a in dirs1)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
