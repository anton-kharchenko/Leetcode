public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
       return GetPaths(obstacleGrid, 1, 1, new int[obstacleGrid.Length + 1, obstacleGrid[0].Length + 1]);  
    }   

    public int GetPaths(int[][] obstacleGrid, int row, int col, int[,] lookup){        
        if(row == obstacleGrid.Length  && col == obstacleGrid[0].Length && obstacleGrid[row - 1][col - 1] != 1){
            return 1;
        }

        if(obstacleGrid[row - 1][col - 1] == 1){
            return 0;
        }

        if(lookup[row, col] != 0){
            return lookup[row, col];
        }

        if(row == obstacleGrid.Length){
            lookup[row, col] =  GetPaths(obstacleGrid, row, col + 1, lookup);
            return lookup[row, col];
        }

        if(col == obstacleGrid[0].Length){
            lookup[row, col] = GetPaths(obstacleGrid, row + 1, col, lookup);
            return lookup[row, col];
        }

        lookup[row, col] = GetPaths(obstacleGrid, row + 1, col, lookup) + GetPaths(obstacleGrid, row, col + 1, lookup);
        return lookup[row, col];
    }
}