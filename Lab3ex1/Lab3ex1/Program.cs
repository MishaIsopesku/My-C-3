using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nВиберіть варіант: \n" +
                    "1 - Старт програми \n" +
                    "2 - Вихід \n" +
                    "Ваш вибір: ");

            int menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Console.Write("Введіть рядок: ");
                String str = Console.ReadLine();
                int indexOfColon = str.IndexOf(':');
                if (indexOfColon != -1)
                {
                    String resultstr = str.Substring(indexOfColon + 1);
                    Console.WriteLine("Символи після ':' - " + resultstr);
                }
                else
                {
                    Console.WriteLine("Символи після ':' - ");
                }

                String[] sentences = str.Split(".");

                int result = 0;
                foreach (String sentence in sentences)
                {
                    String[] words = sentence.Trim().Split(" ");
                    if (words.Length % 2 != 0)
                    {
                        result++;
                    }
                }

                Console.WriteLine("Кількість речень, що містять непарну кількість слів - " + result);

            }
            else
            {
                break;
            }
        }
    }
}
