/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<TreeNode> GenerateTrees(int n) {
        return Dfs(1, n);
    }
    
    List<TreeNode> Dfs(int start, int end){
     if(start>end){
         return new List<TreeNode>{null};
     }
        
     if(start == end){
         return new List<TreeNode>{new TreeNode(start)};
     }   
        var res = new List<TreeNode>();
        
        for(var i = start; i<=end; i++){
            
            var left = Dfs(start, i-1);
            var right = Dfs(i+1, end);
            foreach(var l in left){
                foreach(var r in right){
                    res.Add(new TreeNode(i){ left = l, right = r });
                }
            }
        }
        
        return res;
    }
}