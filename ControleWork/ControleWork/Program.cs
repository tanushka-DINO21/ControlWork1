using System;

namespace ControleWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив строк");
            string[] mas = Console.ReadLine().Split(' ');
            string result = null;

            for (int i = 0; i < mas.Length; i++) 
            {
                if (mas[i].Length <= 3)
                {
                    result += mas[i] + " ";
                }
            }

            string[] res = result.Split(" ");

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
