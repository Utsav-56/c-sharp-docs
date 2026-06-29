class Matrix
{
    int rows;
    int cols;
    int [,] mat;
    
    public Matrix(int [,] data)
    {
        this.mat = data;

        rows = data.GetLength(0);
        cols = data.GetLength(1);
    }

    public void display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {   
                Console.Write(mat[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        
        var arr = new int[m1.rows, m1.cols];
        Matrix result =  new Matrix(arr);

        for (int i = 0; i < m1.rows; i++)
        {
            for (int j = 0; j < m1.cols; j++)
            {   
                arr[i,j] = m1.mat[i,j] + m2.mat[i,j];
            }
        }
         return result;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        var a = new int[2,2]
        {
            {1,2},
            {3,4 }
        };

        var b = new int[2,2]
        {
            {3,4}, 
            {5,6}
        };

        Matrix m1 = new Matrix(a);
        Matrix m2 = new Matrix(b);

        Matrix m3 = m1 + m2;
        m3.display();
    }
}
