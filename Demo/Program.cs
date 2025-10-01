namespace Demo
{
    internal class Program
     
{
        static void Swap(int x, int y)
        {
            Console.WriteLine("swapping");
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            #region Question01
                                                            //int x             passingByValue       
            //1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
               //if we passing parameter by value , we pass the value itself not the address ,
               //if we pass paramter by rtefernce , we pass the address itself , then any changes will do int the function will affect on the real parameter .

              
            int A = 3;
            int B = 5;
            Console.WriteLine($"before the swapping :\n A={A} \n B={B}");
            Swap(A,B)
                Console.WriteLine($"after the swapping :\n A={A} \n B={B}");
            #endregion
        }
    }
}
