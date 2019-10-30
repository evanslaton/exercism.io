using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] pascalsTriangle = new int[rows][];
        if (rows == 0) return pascalsTriangle;

        pascalsTriangle[0] = new int[]{1};
        for (int row = 1; row < rows; row++)
        {
            int[] currentRow = new int[row + 1];
            currentRow[0] = 1;
            currentRow[currentRow.Length - 1] = 1;

            for (int column = 1; column < currentRow.Length - 1; column++)
            {
                currentRow[column] = pascalsTriangle[row - 1][column - 1] + pascalsTriangle[row - 1][column];
            }
            pascalsTriangle[row] = currentRow;
        }
        return pascalsTriangle;
    }
}