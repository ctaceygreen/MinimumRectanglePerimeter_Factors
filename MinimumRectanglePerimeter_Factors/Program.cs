using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        //Find the factors of the area.
        //When found a factor and the symmetric factor, Do 2(A+B) and compare to min perimeter

        int minPerimeter = int.MaxValue;
        int rootN = (int)Math.Sqrt(N);
        for(int i = 1; i <= rootN; i++)
        {
            if(N % i == 0)
            {
                int symmetricFactor = N / i;
                int perimeter = 2 * (i + symmetricFactor);
                if(perimeter < minPerimeter)
                {
                    minPerimeter = perimeter;
                }
            }
        }
        return minPerimeter;
    }
}