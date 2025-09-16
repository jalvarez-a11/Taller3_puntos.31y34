using System;

namespace Geometry
{
    public abstract class Matrix
    {
        public int N { get; set; }
        public int[,] Data { get; set; }

        public Matrix(int n)
        {
            N = n;
            Data = new int[N, N];
        }

        // each one defines how to name
        public abstract void Fill();

        // to show the complete matrix
        public virtual void Print()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{Data[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}