using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_7_Tumakov
{
    internal class Program
    {
        //Копия задания 8.1
        //public bool TransferTo(BankAccount destinationAccount, decimal amount)
        //{
        //    if (Withdraw(amount))
        //    {
        //        destinationAccount.Deposit(amount);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //Задание 8.2
        public static string ReverseString(string inputStr)
        {
            char[] charArray = inputStr.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Задание 8.4
        public static bool IsIFormattable(object obj)
        {
            bool isFormattable = obj is IFormattable;

            IFormattable formattableObj = obj as IFormattable;
            bool isFormattable2 = formattableObj != null;

            if (isFormattable != isFormattable2)
            {
                Console.WriteLine("Ошибка: операторы is и as дали разные результаты.");
            }

            return isFormattable;
        }

        static void Main(string[] args)
        {
            //Задание 8.2
            Console.WriteLine("Задание 8.2");
            string str1 = "12345";
            string str2 = ReverseString(str1);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadKey();

            //Задание 8.3
            Console.WriteLine("Задание 8.3");
            Console.WriteLine("Введите имя файла:");
            string inputFilePath = Console.ReadLine();

            try
            {
                File.ReadAllText(inputFilePath);
            }
            catch (FileNotFoundException)
            {
                Environment.Exit(0);
            }
            string fileStr = File.ReadAllText(inputFilePath);
            string outputFilePath = "output.txt";
            File.WriteAllText(outputFilePath, fileStr.ToUpper());
            Console.ReadKey();

            //Задание 8.4
            Console.WriteLine("Задание 8.4");
            string teststr = "Hello";
            int testnum = 123;
            Console.WriteLine(IsIFormattable(teststr));
            Console.WriteLine(IsIFormattable(testnum));
            Console.ReadKey();
        }
    }
}

