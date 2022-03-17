using System;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Bir integer eded qebul edib, bu ededi binary edede chevirende neche
            // 1 oldugunu tapin. Mes: input 7(binary chevirende 111 alinir), output 3.

            Console.WriteLine(TurnBinary(8));
        }

        static int TurnBinary(int n)
        {
            int rem = 0;
            int rev = 0;
            int count = 0;
            for (int i = 0; n > 0; i++)
            {
                rem = n % 2;
                n = n / 2;
                rev = rev * 10 + rem;
                if (rem == 1)
                {
                    count++;
                }
                
                
            }
            return count;
        }
    }
}
