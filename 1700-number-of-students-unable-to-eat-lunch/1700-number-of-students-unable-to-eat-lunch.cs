public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var q1 = new Queue<int>();
        var q2 = new Queue<int>();
 
        for(var i = 0; i<students.Length; i++){
            q1.Enqueue(students[i]);
            q2.Enqueue(sandwiches[i]);
        }
        
        var count = 0;
        int len = students.Length;
        
        while(count<len){
            if(q2.Peek() == q1.Peek()){
                q2.Dequeue();
                q1.Dequeue();
                count = 0;
                len--;
            }
            else{
                q1.Enqueue(q1.Dequeue());
                count++;
            }
        }
        
        return count;
    }
}