public class Solution {
    int[] parent;
    int[] rank;
    public int[] FindRedundantConnection(int[][] edges) {
        parent = new int[edges.Length + 1];
        rank = new int[edges.Length + 1];
        for(var i = 1; i<= edges.Length; i++){
            parent[i] = i;
            rank[i] = 0;
        }
        
        foreach(var edge in edges){
            if(!CanUnion(edge[0], edge[1])){
                return new int[2]{edge[0], edge[1]};
            }
        }
        
        return new int[2];
    }
    
    public int Find(int x){
        if(parent[x] != x){
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }
    
    public bool CanUnion(int firstNode, int secondNode){
        var parentFirstNode = Find(firstNode);
        var parentSecondNode = Find(secondNode);
        
        if(parentFirstNode == parentSecondNode) return false;
        if(parentFirstNode> parentSecondNode){
            parent[parentSecondNode] = parentFirstNode;
        }else if(parentFirstNode< parentSecondNode){
            parent[parentFirstNode] = parentSecondNode;
        }else {
            parent[parentSecondNode] = parentFirstNode;
            rank[parentFirstNode]++;
        }
        
        return true;
    }
}