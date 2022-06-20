using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = 1;
        //Array.Sort method : sorts the elements in a one-dimensional array
        Array.Sort(A);

        for (int i = 0; i <= 100000; i++)
        {
            for (int j = 0; j <= A.Length - 1; j++)
            {
                if (A[i] == i)
                {
                    N = A[j] + 1;
                }
            }
            break;
        }
        return N;
    }
}