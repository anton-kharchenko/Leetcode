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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Build(nums, 0, nums.Length - 1);
    }
    
    public int FindMax(int[] arr, int start, int end){
        int maxValue = 0;
        int index = 0;
        
        for(var i = start; i<= end; i++){
            if(arr[i] > maxValue){
                maxValue = arr[i];
                index = i;
            }
        }
        
        return index;
    }
    
    public TreeNode Build(int[] arr, int start, int end){
        if(start> end)
            return null;
        
        if(start==end)
            return new TreeNode(arr[start]);
        
        int index =  FindMax(arr, start, end);
        
        var root = new TreeNode(arr[index]);
        
        root.left = Build(arr, start, index - 1);
        root.right = Build(arr, index + 1, end);
        
        return root;
    }
}