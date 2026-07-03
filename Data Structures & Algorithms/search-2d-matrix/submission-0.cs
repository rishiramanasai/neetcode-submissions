public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        for(int i = 0; i < rows; i++){
            if(matrix[i][columns -1] >= target){
                for(int j = 0; j < columns ; j++){
                    if(matrix[i][j] > target) return false;
                    if(matrix[i][j] == target){
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
