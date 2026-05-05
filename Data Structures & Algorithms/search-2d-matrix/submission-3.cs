public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        int left = 0;
        int right = (rows * columns )-1 ;
        while (left <= right){
            int mid = left + (right-left)/2;
            int row =  mid/ columns;
            int col =  mid% columns;
            int midValue = matrix[row][col];

            if(midValue == target){
                return true;
            }
            else if(midValue<target){
                left = mid+1;
            }
            else{
                right = mid-1;
            }

        }
        return false;
    }
}
