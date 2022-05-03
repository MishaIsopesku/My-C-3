using System;

class Program
{
    static void Main()
    {
        Console.Write("\nВиберіть варіант: \n" +
                    "1 - Старт програми \n" +
                    "2 - Вихід \n" +
                    "Ваш вибір: ");
        string s = Console.ReadLine();


        switch (s)
        {
         case "1":
                int[] array = Array.ConvertAll(File.ReadAllLines("C:\\1.txt"), e => e.Length);

                {
                    for (int i = 0; i < array.Length; Console.WriteLine($"Рядок {i + 1}, кількість символів: {array[i++]}")) ;
                }
                break;


         case "2":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Программа завершила роботу");
                Console.ResetColor();
                break;
        }
    }
}
