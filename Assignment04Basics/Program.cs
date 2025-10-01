namespace Demo
{
    internal class Program

    {
    
        static void Main(string[] args)
        {
            #region Question01
            //1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            #region Passing by value
            //   A copy of the variable’s value is passed into the method.
            //   Any changes inside the method do NOT affect the original variable.
            #endregion
            #region passing by reference
            //The method receives the actual memory address of the variable. Any changes inside the method directly affect the original variable.
            #endregion

            ///passing by value example :
            ///static void Swap(int x, int y)
            ///{
            ///    Console.WriteLine("swapping");
            ///    int temp;
            ///    temp = x;
            ///    x = y;
            ///    y = temp;
            ///}
            ///int A = 3;
            ///int B = 5;
            ///Console.WriteLine($"before the swapping :\n A={A} \n B={B}");
            ///Swap(A, B);
            ///    Console.WriteLine($"after the swapping :\n A={A} \n B={B}");
            ///    

            ///passing by reference example :
            ///static void Swap(ref int x, ref int y)
            ///{
            ///    Console.WriteLine("swapping");
            ///    int temp;
            ///    temp = x;
            ///    x = y;
            ///    y = temp;
            ///}
            ///int A = 3;
            ///int B = 5;
            ///Console.WriteLine($"before the swapping :\n A={A} \n B={B}");
            ///Swap(ref A, ref B);
            ///Console.WriteLine($"after the swapping :\n A={A} \n B={B}");


            #endregion
        }
    }
}
