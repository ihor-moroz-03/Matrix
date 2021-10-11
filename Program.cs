using System;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            Matrix m = new Matrix(new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });

            foreach (double coef in m)
            {
                Console.WriteLine(coef);
            }

            Console.Read();
        }
    }
}
