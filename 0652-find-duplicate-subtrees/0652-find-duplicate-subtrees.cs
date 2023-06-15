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
    IList<TreeNode> res =  new List<TreeNode>();
    Dictionary<string, int> dict = new Dictionary<string, int>();
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        if(root == null) return res;
        DFS(root);
        return res;
    }
    
    public string DFS(TreeNode node){
        if(node == null) return "-";
        var val = node.val.ToString() + "-" + DFS(node.left) + DFS(node.right);
        
        if(!dict.ContainsKey(val)){
            dict.Add(val, 1);
        }else{
            dict[val] += 1;
        }
        
        if(dict[val] == 2)
            res.Add(node);
        
        return val;
    }
}