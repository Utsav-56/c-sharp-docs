/*
ARRAYS IN C#
An array is a data structure that stores a fixed number of values of the same type under same name.

Arrays values are stored in contiguous memory locations,
And can be accessed using an index which starts from 0.

Types of arrays in C#:
1. Single-Dimensional Arrays:
    - An array that has only one dimension.
    - It is declared using a single square brackets [].

2. Multi-Dimensional Arrays:
    - An array that has more than one dimension.
    - The dimensions are seperated by commas
    - For example, a 2D array is declared as int[,] arrayName = new int[2, 3];
    


3. Jagged Arrays:
    - An array of arrays, where each inner array can have a different length
    - They are declared using two sets of square brackets [][].

*/


class Program
{
    static void Main(string[] args)
    {
        // Example of single-dimensional array
        int[] singleDimensionalArray = new int[5] { 1, 2, 3, 4, 5 };

        // Example of multi-dimensional array (2D array)
        int[,] multiDimensionalArray = new int[2, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        // Example of jagged array
        int[][] jaggedArray = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6 }
        };



        /*
        ACCESSING ARRAY ELEMENTS:
        We can access array elements using their index.
        */
        Console.WriteLine(singleDimensionalArray[0]); // Output: 1
        Console.WriteLine(multiDimensionalArray[0, 1]); // Output: 2
        Console.WriteLine(jaggedArray[1][2]); // Output: 5

        /*
        We can also use loops to iterate through the elements of an array.
        */
        Console.WriteLine("Single-Dimensional Array:");
        foreach (var item in singleDimensionalArray)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Multi-Dimensional Array:");
        /*
        For multi dimensional arrays, we dont need to use nested loops
        because it automatically iterates through all the elements in the array, 
        
        */

        foreach (var item in multiDimensionalArray)
        {
            Console.WriteLine(item);
        }




        Console.WriteLine("Jagged Array:");
        /*
        For jagged arrays, we need to use nested loops to access the elements of the inner arrays.
         
        */


        foreach (var innerArray in jaggedArray)
        {
            foreach (var item in innerArray)
            {
                Console.WriteLine(item);
            }
        }

    }

}
