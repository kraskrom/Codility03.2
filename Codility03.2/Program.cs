/*
An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.

Your goal is to find that missing element.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A, returns the value of the missing element.

For example, given array A such that:

  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
the function should return 4, as it is the missing element.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
the elements of A are all distinct;
each element of array A is an integer within the range [1..(N + 1)].
*/

using System;

namespace Codility03._2
{
    class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            double s = (n + 1.0) * (n + 2) / 2;
            for (int i = 0; i < n; i++)
                s -= A[i];
            return (int)s;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] A = new int[100000];
            for (int i = 0; i < 100000; i++)
                A[i] = i + 2;
            Solution sol = new Solution();
            int s = sol.solution(A);
            Console.WriteLine("Solution: " + s);
        }
    }
}
