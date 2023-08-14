public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var q = new Queue<string>();
        var set = new HashSet<string>(wordList);
        var level = 2;
        
        set.Remove(beginWord);
        q.Enqueue(beginWord);

        while (q.Count > 0)
        {
            var size = q.Count;
           
            for (var i = size; i > 0; i--)
            {
                var curr = q.Dequeue();
                var templist = new List<string>();

                foreach (var j in set)
                {
                    if (HaveOneDiff(curr, j))
                    {
                        if (j == endWord)
                        {
                            return level;
                        }

                        q.Enqueue(j);
                        templist.Add(j);
                    }
                }

                foreach (var item in templist)
                {
                    set.Remove(item);
                }
            }


            level++;
        }


        return 0;
    }

    public bool HaveOneDiff(string source, string dest)
    {
        var hasOneDiff = false;

        for (var i = 0; i < source.Length; i++)
        {
            if (source[i] != dest[i])
            {
                if (hasOneDiff)
                {
                    return false;
                }

                hasOneDiff = true;
            }
        }


        return true;
    }
}