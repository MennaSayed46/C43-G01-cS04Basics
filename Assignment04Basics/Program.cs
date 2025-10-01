using System.ComponentModel;

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

            #region Question02
            //2 - Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example
            #region passing by value
            ///   The method receives a copy of the reference (the address of the object).
            ///   This means you can modify the object’s contents (e.g., array elements),
            ///   but if you reassign the reference to a new object, the original variable
            ///  outside the method will NOT be affected.
            ///static int SumArray(int[] arr)
            ///{
            ///    int sum = 0;
            ///    arr[0] = 100; //this will affect the original array.
            ///    if (arr is not null)
            ///        for(int i =0; i<arr.Length; i++)
            ///            sum+=arr[i];
            ///    return sum;
            ///}
            ///
            ///int[] numbers = { 1, 2, 3 };
            ///Console.WriteLine($"before the sumArr \n numbers[0] ={numbers[0]}"); //1
            ///int result = SumArray(numbers);
            ///Console.WriteLine($"after the sumArray \n numbers[0] = {numbers[0]}");  //100
            ///Console.WriteLine($"the sum of the aarray is : {result}");
            #endregion

            #region Passing by refernce
            /// - Passing a reference type by Reference (using ref keyword):
            ///   The method receives the actual reference itself, not just a copy.
            ///   This means both modifying the object’s contents AND reassigning the reference
            ///   will directly affect the original variable outside the method.
            /// static int SumArray(int[] arr)
            /// {
            ///    int sum = 0;
            ///    arr = new int[] { 4,5,6}; //this do not affect the original array.
            ///if (arr is not null)
            ///        for (int i = 0; i < arr.Length; i++)
            ///            sum += arr[i];
            ///    return sum;
            /// }
            ///int[] numbers = { 1, 2, 3 };
            ///Console.WriteLine($"before the sumArr \n numbers[0] ={numbers[0]}"); //1
            ///int result = SumArray(numbers); //15
            ///Console.WriteLine($"after the sumArray \n numbers[0] = {numbers[0]}");  //1
            ///Console.WriteLine($"the sum of the aarray is : {result}");  //15

            #endregion
            #endregion

            #region Question03
            //3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

                ///static void sumSubstract(int a , int b , out int sum , out int substract)
                ///{
                ///    sum = a + b;
                ///    substract = a - b;
                ///}

                ///int sumResult, substractResult;
                ///sumSubstract(10, 5, out sumResult, out substractResult);
                ///Console.WriteLine($"the sum of 10 + 5 ={sumResult}");
                ///Console.WriteLine($"the substract of 10 - 5 = {substractResult}");
            #endregion
        }
    }
}
