using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Program
    {
        public static void Color(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(txt);
            Console.ResetColor();
        }

        public static void Error(string txt)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(txt);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            bool ok = true;
            string str = "";
            Color("Введите сообщение:");
            do
            {
                str = Console.ReadLine();
                for (int i = 0; i < str.Length; i++)
                {
                    char m = str[i];
                    if ((m < '0') || (m > '1'))
                    {
                        Error("Ошибка, сообщение может содержать только цифры \"0\" и \"1\"");
                        ok = false;
                        break;
                    }
                    else if (str.Length % 3 != 0)
                    {
                        Error("Ошибка, сообщение должно быть кратно 3");
                        ok = false;
                        break;
                    }
                    else ok = true;
                }
            } while (!ok);

            Color("Расшифрованное сообщение:");
            for (int j=0; j < str.Length;)
            {
                int count0 = 0, count1 = 0;
                for (int m=0; m < 3; m++)
                {
                    if (str[j + m] == '0') count0++;
                    else count1++;
                }
                if (count0>1) Console.Write("0 ");
                else Console.Write("1 ");
                j += 3;
            }
            Console.ReadKey();
        }
    }
}
