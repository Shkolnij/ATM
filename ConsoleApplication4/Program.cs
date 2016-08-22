using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть слово ");
            string a = Console.ReadLine();
            int t = 0;
            Console.Write("Введіть режим (1 або 2) ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введіть шлях до файлу ");
            string c = @""+ Console.ReadLine();
            string mas = File.ReadAllText(c);
            string[] nums = mas

            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i].IndexOf(a) > -1)

                {
                    if (b == 2)
                    {
                        if (string.Equals(nums[i], a) == true)
                        {
                            t = t + 1;

                        }
                    }
                    else
                        t = t + 1;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Число повторів = "+ t);
            Console.ReadKey();
        }
    }
}

