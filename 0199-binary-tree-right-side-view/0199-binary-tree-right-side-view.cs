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
    public IList<int> RightSideView(TreeNode root) {
          IList<int> list = new List<int>();
          helper(root, list, 1);
          return list;
    }


void helper(TreeNode root, IList<int> lst, int level)
      {
          if (root == null) return;
    
          if(level > lst.Count)
          {
              lst.Add(root.val);
          }
    
          helper(root.right, lst, level + 1);
          helper(root.left, lst, level + 1);
      }
}