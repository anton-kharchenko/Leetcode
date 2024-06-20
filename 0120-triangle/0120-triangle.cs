public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        var lookup = new List<IList<int>>();
        lookup.Add(new List<int>());
        lookup[0].Add(triangle[0][0]);
        
        for (int i = 1; i < triangle.Count; i++)
        {
            lookup.Add(new List<int>());
            
            for (int j = 0; j < triangle[i].Count; j++)
            {
                if (j == 0)
                {
                    lookup[i].Add( lookup[i - 1][0] + triangle[i][j]);
                }
                else if (j ==  triangle[i].Count - 1)
                {
                    lookup[i].Add( lookup[i - 1][^1] + triangle[i][j]);
                }
                else
                {
                    lookup[i].Add(Math.Min(lookup[i - 1][j - 1], lookup[i - 1][j]) + triangle[i][j]);
                }
            }
        }
        
        return lookup.Last().Min();
       // return Recursion(triangle, 0, 0, new int[triangle.Count, triangle[^1].Count]);
    }

    public int Recursion(IList<IList<int>> triangle, int index, int finish, int[,] lookup)
    {
        if (finish == triangle.Count)
        {
            return 0;
        }

        if (index >= triangle[finish].Count)
        {
            return 0;
        }

        if (lookup[finish, index] != 0)
        {
            return lookup[finish, index];
        }

        lookup[finish, index] = Math.Min(triangle[finish][index] + Recursion(triangle, index + 1, finish + 1, lookup),
            triangle[finish][index] + Recursion(triangle, index, finish + 1, lookup));

        return lookup[finish, index];
    }
}