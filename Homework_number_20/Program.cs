using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] {{ 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 7, 8, 9 }};
            int rowNumber = 1;
            int columnNumber = 0;
            int rowSum = 0;
            int sumColumn = 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                rowSum += matrix[rowNumber, i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumColumn *= matrix[i, columnNumber];
            }

            Console.WriteLine("Матрица:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма элементов второй строки: " + rowSum);
            Console.WriteLine("Произведение элементов первого столбца: " + sumColumn);

            Console.ReadKey();
        }
    }
}
