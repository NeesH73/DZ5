using System;
using System.IO;
using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;

namespace DZ5
{
    internal class Program
    {
        static int FindGlas(char[] array)
        {
            int countsogl = 0;
            char[] array1 = { 'а', 'я', 'е', 'ё', 'ю', 'и', 'ы', 'у', 'о', 'э' };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array[i] == array1[j])
                    {
                        countsogl++;
                    }
                }
            }
            return countsogl;

        }
        static int FindSogl(char[] array)
        {
            int countglas = 0;
            char[] array1 = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array[i] == array1[j])
                    {
                        countglas++;
                    }
                }
            }
            return countglas;
        }
        static int FindGlasWithlist(List<char> arraylist)
        {
            int countglas = 0;
            char[] array1 = { 'а', 'я', 'е', 'ё', 'ю', 'и', 'ы', 'у', 'о', 'э' };
            foreach (char c in arraylist)
            {
                if (array1.Contains(c))
                {
                    countglas++;
                }
            }
            return countglas;
        }
        static int FindSoglWithlist(List<char> arraylist)
        {
            int countsogl = 0;
            char[] array1 = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            foreach (char c in arraylist)
            {
                if (array1.Contains(c))
                {
                    countsogl++;
                }
            }
            return countsogl;
        }
        static int[,] TwoMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] summa = new int[2, 2];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(0); j++)
                {
                    summa[i, j] = matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1] * matrix2[1, j];
                }
            }

            return summa;
        }
        static void PrintMatrix(int[,] matrix)
        {
            int stroki = matrix.GetLength(0);
            int stol = matrix.GetLength(1);

            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stol; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }






        static void Main(string[] args)
        {
            Console.WriteLine("Упр 6.1: Подсчитать кол-во гласных и согласных ");
            string file = File.ReadAllText("C:\\Users\\ignat\\source\\repos\\Tymakov6\\DZ5\\file.txt");
            char[] array = new char[file.Length];
            for (int i = 0; i < file.Length; i++)
            {
                array[i] = file[i];
            }
            Console.WriteLine($"Количество согласных - {FindSogl(array)}");
            Console.WriteLine($"Количество гласных - {FindGlas(array)}");



            Console.WriteLine("Упр 6.2: Решить матрицу");
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            Random ran = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix1[i, j] = ran.Next(1, 15);
                    matrix2[i, j] = ran.Next(1, 15);

                }
            }
            int[,] result = TwoMatrix(matrix1, matrix2);
            Console.WriteLine($"Первая матрица: ");
            PrintMatrix(matrix1);
            Console.WriteLine($"Вторая матрица: ");
            PrintMatrix(matrix2);
            Console.WriteLine("Полученная матрица :");
            PrintMatrix(result);



            Console.WriteLine("ДЗ 6.1: Найти кол-во гласных, согласных с помощью list");
            List<char> array1 = new List<char>();
            for (int i = 0;i < file.Length;i++)
            {
                array1.Add(file[i]);
            }
            Console.WriteLine($"Количество согласных - {FindSoglWithlist(array1)}");
            Console.WriteLine($"Количество гласных - {FindGlasWithlist(array1)}");


        }
    }
}
