/*
Wap to define a class named Matrix and use operator overloading to perform matrix addition and multiplication.
*/

using System;

class Matrix
{
    public int[,] data;
    public int rows, cols;

    public Matrix(ref int[,] arr)
    {
        data = arr;

        rows = arr.GetLength(0);
        cols = arr.GetLength(1);
    }


    /*
    Indexer to access matrix elements
        - Allows us to use the syntax m[i, j] to access the element at row i and column j of the matrix.
    */
    public int this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }


    /*
    We make a display method to print the matrix in a readable format.
    */
    public void Display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix result = new Matrix(m1.rows, m1.cols);

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.cols; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }
}


class Program
{
    static void Main(string[] args)
    {
        int[,] a = {
            { 1, 2 },
            { 3, 4 }
        };

        int[,] b = {
            { 5, 6 },
            { 7, 8 }
        };

        Matrix m1 = new Matrix(ref a);
        Matrix m2 = new Matrix(ref b);

        Matrix m3 = m1 + m2;

        Console.WriteLine("Sum of matrices:");
        m3.Display();

    }
}