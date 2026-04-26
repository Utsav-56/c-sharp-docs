/*
Wap to define a class named Matrix and use operator overloading to perform matrix addition and multiplication.
*/

using System;

class Matrix
{
    public int[,] data;
    public int rows, cols;

    /*
    Ref means passing pointer to array,
    must know types of params to understand ref
    */
    public Matrix(ref int[,] arr)
    {
        data = arr;

        /*
        GetLength() method is used to get the number of rows and columns in the array.

        GetLength(0) returns the number of rows (the length of the first dimension).
        GetLength(1) returns the number of columns (the length of the second dimension).
        */
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
        if (m1.rows != m2.rows || m1.cols != m2.cols)
        {
            throw new Exception("Matrices must have the same dimensions for addition.");
        }

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


    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.cols != m2.rows)
        {
            throw new Exception("Number of columns in the 1st matrix must be equal to the number of rows in the 2nd matrix.");
        }

        Matrix result = new Matrix(m1.rows, m2.cols);

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m2.cols; j++)
            {

                for (int k = 0; k < m1.cols; k++)
                {
                    result[i, j] += m1[i, k] * m2[k, j];
                }
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
        Matrix m4 = m1 * m2;

        Console.WriteLine("Sum of matrices:");
        m3.Display();

        Console.WriteLine("Product of matrices:");
        m4.Display();
    }
}