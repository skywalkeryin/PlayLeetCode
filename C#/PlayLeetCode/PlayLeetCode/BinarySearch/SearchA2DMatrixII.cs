using System;
using System.Collections.Generic;
using System.Text;

namespace PlayLeetCode.BinarySearch
{
    //https://leetcode.com/problems/search-a-2d-matrix-ii/
    class SearchA2DMatrixII
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[,] matrix = new int[,] { { 1, 4, 7, 11, 15 },
                {2,   5,  8, 12, 19}, 
                {3,   6,  9, 16, 22}, 
                {10, 13, 14, 17, 24}, 
                {18, 21, 23, 26, 30},
            };
            s.SearchMatrix(matrix, 5);
        }

        public class Solution
        {
            public bool SearchMatrix(int[,] matrix, int target)
            {

                int n = matrix.GetLength(0);
                int m = matrix.GetLength(1);

                if (n == 0 && m == 0)
                {
                    return false;
                }
                int x = n - 1;
                int y = 0;

                while ((x >= 0 && x < n) && y >= 0 && y < m)
                {
                    if (matrix[x, y] == target)
                    {
                        return true;
                    }
                    else if (matrix[x, y] < target)
                    {
                        y += 1;
                    }
                    else
                    {
                        x -= 1;
                    }
                }

                return false;
            }
        }
    }
}
