/*
Wap to define a class named Matrix and use operator overloading to perform matrix addition and multiplication.
*/

using System;

class Matrix
{

    public int Rows { get; }
    public int Cols { get; }
    public int[,] data;


    public Matrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        data = new int[rows, cols];
    }

    public int this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }


    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            throw new InvalidOperationException("Matrices must have the same dimensions for addition.");

        Matrix result = new Matrix(m1.Rows, m1.Cols);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }


    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.Cols != m2.Rows)
            throw new Exception("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");

        Matrix result = new Matrix(m1.Rows, m2.Cols);

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m2.Cols; j++)
            {
                int sum = 0;
                for (int k = 0; k < m1.Cols; k++)
                {
                    sum += m1[i, k] * m2[k, j];
                }
                result[i, j] = sum;
            }
        }
        return result;
    }

}


class Program
{
    static void Main(string[] args)
    {
        Matrix m1 = new Matrix(2, 2);
        m1[0, 0] = 1; m1[0, 1] = 2;
        m1[1, 0] = 3; m1[1, 1] = 4;

        Matrix m2 = new Matrix(2, 2);
        m2[0, 0] = 5; m2[0, 1] = 6;
        m2[1, 0] = 7; m2[1, 1] = 8;

        Matrix sum = m1 + m2;
        Matrix product = m1 * m2;

        Console.WriteLine("Sum of matrices:");
        PrintMatrix(sum);

        Console.WriteLine("Product of matrices:");
        PrintMatrix(product);
    }

    static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}