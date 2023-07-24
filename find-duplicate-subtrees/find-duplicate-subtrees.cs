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
    IList<TreeNode> result = new List<TreeNode>();
    Dictionary<string, int> dictionary = new  Dictionary<string, int>();
    
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {

        Dfs(root);
        return result;
    }
    
    public string Dfs(TreeNode node){
        if(node == null){
            return "-";
        };
        
        var val = node.val.ToString() + "-" + Dfs(node.left) + Dfs(node.right);
        
        if(dictionary.ContainsKey(val)){
            dictionary[val]++;
        }else{
            dictionary.Add(val, 1);
        }
        
        if(dictionary[val] == 2)
            result.Add(node);
        
        return val;
    }

}