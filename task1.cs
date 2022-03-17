using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                //TASK 1.Integer array qebul edib geriye bu arrayin en boyuk
                //elementini qaytaran metod yazin. Mes: input { 10,50,-5,34},
                //output 50.

     Bigger(10, 5, 42, 58,7,9);
        }

        static void Bigger(params int[] arr)
        {
            int biggernum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        if (biggernum>arr[i])
                        {
                            biggernum = biggernum;
                        }
                        else
                        {
                            biggernum = arr[i];
                        }
                        
                    }

                    if (arr[i] < arr[j])
                    {
                        if (biggernum > arr[j])
                        {
                            biggernum = biggernum;
                        }
                        else
                        {
                            biggernum = arr[j];
                        }
                    }


                }
            }
            Console.WriteLine(biggernum);
        }
    }
}