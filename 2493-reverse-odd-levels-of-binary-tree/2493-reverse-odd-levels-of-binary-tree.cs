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
    private List<int> res = new List<int>();
    public TreeNode ReverseOddLevels(TreeNode root) {
        BFS(root);
        var newTree = BuildTree();
        return newTree;
    }

    private TreeNode BuildTree()
    {
        if (res.Count == 0)
        {
            return null;
        }

        TreeNode newTreeNode = new TreeNode(res[1]);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(newTreeNode);
        int index = 1;
            
        while (queue.Count > 0)
        {
            if(index * 2 + 1 >= res.Count) break;
            var node = queue.Dequeue();
            var leftChild = res[index * 2];
            var rightChild = res[index * 2 + 1];
            node.left = new TreeNode(leftChild);
            node.right = new TreeNode(rightChild);
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
            index += 1;
        }
        
        return newTreeNode;
    }

    private void BFS(TreeNode node){
        if(node is null){
            return;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(node);
        var isOddLevel = true;
        res.Add(0);
        res.Add(node.val);

        while(queue.Any()){
            var size = queue.Count;
            var tempList = new List<int>();

            for(var i = 0; i<size; i++){
                var n = queue.Dequeue(); 
                
                if(n.left != null){
                    queue.Enqueue(n.left);
                    tempList.Add(n.left.val);
                }
                if(n.right != null){
                    queue.Enqueue(n.right);
                    tempList.Add(n.right.val);
                }
            }
            
            if(isOddLevel)
                tempList.Reverse();
            
            foreach (var value in tempList)
                res.Add(value);
            
            isOddLevel = !isOddLevel;
        }
    }
}