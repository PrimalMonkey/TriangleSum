using System;

namespace TestTriangle
{
    class Program
    {
        static void Main()
        {
            // представил треугольник в виде матрицы, в которой выше главной диагонали нули
            Console.WriteLine("Enter dimension of matrix (Count of elements at the base of the triangle)");
            int n = Convert.ToInt32(Console.ReadLine()); // n - размерность матрицы
            int[,] randArr = new int[n, n];

            Random rd = new Random(); // генерация матрицы (треугольника)
            for (int i = 0; i < n; i++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    randArr[i, j1] = rd.Next(10);
                    if (i + 1 <= j1)
                    {
                        randArr[i, j1] = 0;
                    }
                    Console.Write(randArr[i, j1] + " ");
                }
                Console.WriteLine();
            }

            int sum = randArr[0, 0]; // начинаю обход с вершины
            int j = 0;
            for (int i = 1; i < n; i++)
            {
                if (j < i) // условие, по которому запрещен выход за главную диагональ
                {
                    if (randArr[i, j] > randArr[i, j + 1]) // запись левого максимума из двух вершин
                    {
                        sum += randArr[i, j];
                    }
                    else
                    {
                        sum += randArr[i, j + 1]; // если элемент справа оказался больше
                        j++;
                    }
                }
                else
                    sum += randArr[i, j];
            }
            Console.WriteLine(sum);
        }
    }
}
