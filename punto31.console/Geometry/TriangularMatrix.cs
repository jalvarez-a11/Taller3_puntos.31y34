using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class TriangularMatrix : Matrix
    {
        public TriangularMatrix(int n) : base(n) { }

        // Llenar con la fórmula i + j
        public override void Fill()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Data[i, j] = i + j;
                }
            }
        }

        // Mostrar solo la triangular inferior
        public void PrintLowerTriangle()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j <= i)
                        Console.Write($"{Data[i, j],4}");
                    else
                        Console.Write("    "); // espacio en blanco
                }
                Console.WriteLine();
            }
        }
    }
}

