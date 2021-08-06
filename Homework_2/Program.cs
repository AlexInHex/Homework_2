using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {            
           
            Console.WriteLine("Введите число строк матрицы: ");
            var rows = Console.ReadLine();

            Console.WriteLine("Введите число столбцов матрицы: ");
            var cols = Console.ReadLine();
            
            int x = int.Parse(rows);
            int y = int.Parse(cols);

            int[,] matrix = new int[y, x];

            int positiveNum = 0;
            int negativeNum = 0;
            int operation;

            // Ввод матрицы с клавиатуры.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Y " + i + " X " + j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Вывод матрицы в консоль таблицей.
            Console.WriteLine();
            Console.WriteLine("Введенная матрица↓↓↓");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("  " + matrix[i,j]);
                }
                Console.WriteLine("  ");
            }

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1 - Найти количество положительных и отрицательных чисел в матрице");
            Console.WriteLine("2 - сортировать элементы в строках матрицы (по убыванию)");
            Console.WriteLine("3 - инвертировать все строки в матрице");
            Console.WriteLine("----------------------------------------------------------------------");
            operation = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------");

            if (operation == 1)
            {
                //Поиск количества положительных и отрицательных членов.
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > 0)
                        {
                            positiveNum++;
                        }

                        if (matrix[i, j] < 0)
                        {
                            negativeNum++;
                        }
                    }
                }
                Console.WriteLine("Количество положительных элементов = " + positiveNum);
                Console.WriteLine("Количество отрицательных элементов = " + negativeNum);
            }
            else if (operation == 2)
            {
                //Реализация сортировки элементов в строках матрицы по убыванию.
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1)-1; j++)
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                        {
                            int element = matrix[i, j];
                            matrix[i, j] = matrix[i, j + 1];
                            matrix[i, j + 1] = element;
                            
                        }                        
                    }                    
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int  j = 0;  j < matrix.GetLength(1);  j++)
                    {
                        Console.Write(" " + matrix[i,j]);
                    }
                    Console.WriteLine("  ");
                }
            }
            else if (operation == 3)
            {

            }
        }
    }
}
