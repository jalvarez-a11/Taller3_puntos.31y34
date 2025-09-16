using Geometry;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        TriangularMatrix matrix = new TriangularMatrix(n);

        Console.WriteLine("\nMatriz completa:");
        matrix.Fill();
        matrix.Print();

        Console.WriteLine("\nTriangular inferior:");
        matrix.PrintLowerTriangle();
    }
}


