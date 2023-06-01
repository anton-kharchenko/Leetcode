public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new List<int>(asteroids.Length);
        
        foreach (var asteroid in asteroids)
        {
            bool add = true;
            while (stack.Any() && stack[^1] > 0 && asteroid < 0)
            {
                if (stack[^1] < -asteroid)
                {
                    stack.RemoveAt(stack.Count - 1);
                    continue;
                }

                add = false;
                if (stack[^1] == -asteroid)
                {
                    stack.RemoveAt(stack.Count - 1);
                }

                break;
            }

            if (add)
            {
                stack.Add(asteroid);
            }
        }

        return stack.ToArray();
    }
}