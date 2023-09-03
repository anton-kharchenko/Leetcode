public class Solution {
    public int UniquePaths(int m, int n)
    {

    var arr = new int[m,n];
  

    for(var i = 0; i<m; i++){
        for(var j = 0; j<n; j++){
            arr[i,j] = 1;
        }
    }

    for(var i = 1; i < m; i++){
        for(var j = 1; j < n; j++){
            arr[i,j] = arr[i-1, j] + arr[i, j-1];
        }
    }

    return arr[m-1, n-1];
    }
}