using System;
namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число: ");
                string num = Console.ReadLine();
                int summ = 0;

                if (!CheckInteger(num))
                {
                    Console.WriteLine("Введено не корректное значение");
                    break;
                }
                else
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        char digitFromNum = (char)num[i];
                        if (i == 0 && digitFromNum == '-')
                        {
                            continue;
                        }
                        else
                        {
                            summ += digitFromNum - '0';
                        }
                    }
                    Console.WriteLine($"Сумма цифр числа: {summ}");
                }
            }
        }

        public static bool CheckInteger(string num)
        {
            bool flag = false;

            for (int i = 0; i < num.Length; i++)
            {
                char digitFromNum = (char)num[i];

                if (i == 0 && digitFromNum == '-')
                {
                    continue;
                }

                if (digitFromNum >= '0' && digitFromNum <= '9')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

    }
}
