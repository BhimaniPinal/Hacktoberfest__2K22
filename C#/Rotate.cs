/**
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation
**/
public class Solution {
    public void Rotate(int[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return;
        
        for (int i = 0; i < matrix.Length - 1; i++)
            for (int j = i + 1; j < matrix[0].Length; j++)
            {
                matrix[i][j] += matrix[j][i];
                matrix[j][i] = matrix[i][j] - matrix[j][i];
                matrix[i][j] -= matrix[j][i];
            }
        
        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length / 2; j++)
            {
                matrix[i][j] += matrix[i][matrix[0].Length - 1 - j];
                matrix[i][matrix[0].Length - 1 - j] = matrix[i][j] - matrix[i][matrix[0].Length - 1 - j];
                matrix[i][j] -= matrix[i][matrix[0].Length - 1 - j];
            }
    }
}
