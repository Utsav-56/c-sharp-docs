class LamdaExpression
{

 static void Main(string[] args)
 {
    int [] arr1 = ()=>
    {
        int [] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for(int i=0; i<10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    };
    
    
    int [] arr2 = ()=>
    {
        int [] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for(int i=0; i<10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    };

    int [] merged = () => arr1.Concat(arr2).ToArray();
 }   
}