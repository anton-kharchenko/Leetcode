public class Solution{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        Queue<string> q = new Queue<string>();
        HashSet<string> set = new HashSet<string>(wordList);
        q.Enqueue(beginWord);
        set.Remove(beginWord);

        int level = 2;

        while (q.Any())
        {
            int size = q.Count;

            for (int i = size; i > 0; i--)
            {
                string curr = q.Dequeue();

                List<string> templist = new List<string>();

                foreach (var item in set)
                {
                    if(HaveOneDifference(curr,item))
                    {
                        if (item == endWord)
                            return level;
                        q.Enqueue(item);
                        templist.Add(item);
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

    public bool HaveOneDifference(string str1, string str2)
    {
        bool seen = false;
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                if (seen == true)
                    return false;
                seen = true;
            }
        }
        return true;
    }
} 
