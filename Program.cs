using System;
using System.IO;
using System.Collections.Generic;
namespace SortingMonster
{
    class Program
    {
        static void Main(string[] args)
        {
           processing(chekFile());
           
            System.Environment.Exit(0);
        }

        static StreamReader chekFile()
        {
            try
            {
                StreamReader file = new StreamReader("input.txt");
               
                    return file;
                
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Данных нет!");
                Console.ResetColor();
                Console.WriteLine("Зайдите в директорию программы, и заполнитей файл \"input.txt\"");
                using (StreamWriter file = new StreamWriter("input.txt"))
                {
                    Console.WriteLine("файл создан");
                }
                return null;
            }
        }
        static void processing(StreamReader file) {
            string[] line = new string[3];
            for (int i = 0; i < 3; i++)
            {
                line[i] = file.ReadLine();
            }
            line[1].Trim();
            line[1] = line[1].Replace(" ", "");
            List<int> number = new List<int>();
            int max_number = 0;
            
            foreach (var item in line[1])
            {
                number.Add(item-48);               
            }

            using (StreamWriter reset = new StreamWriter("output.txt", false));
                for (int i = 0; i < Convert.ToInt32(line[2]); i++)
                {
                foreach (var item in number)
                {
                    if (item > max_number)
                    {
                        max_number = item;
                    }
                }
                using (StreamWriter file2 = new StreamWriter("output.txt", true))
                {
                    file2.Write(max_number + " ");
                }
                number.Remove(max_number);
                max_number = 0;
                }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nВсе готово, чекните файл output.txt\n");
            Console.ResetColor();
        }
    }
}
    

