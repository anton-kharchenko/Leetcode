public class Twitter {
    
    public Dictionary<int, HashSet<int>> userFollowsDict; 
    public Dictionary<int, PriorityQueue<int,int>> userTweetsDict; 
    public int timestamp; 
    
    public class CustomComparer : IComparer<int> {
        public int Compare(int firstVal, int secondVal) {
            return secondVal.CompareTo(firstVal); // max heap 
        }
    }

    public Twitter() {
        userFollowsDict = new Dictionary<int, HashSet<int>>(); 
        userTweetsDict = new Dictionary<int, PriorityQueue<int,int>>(); 
        timestamp = 0; 
    }
    
    public void PostTweet(int userId, int tweetId) {
        if (userTweetsDict.ContainsKey(userId)) {
            userTweetsDict[userId].Enqueue(tweetId, timestamp); 
        } else {
            userTweetsDict.Add(userId, new PriorityQueue<int, int>(new CustomComparer()));
            userTweetsDict[userId].Enqueue(tweetId, timestamp); 
        }
        timestamp++; 
    }
    
    public IList<int> GetNewsFeed(int userId) {
        
        var allResults = new PriorityQueue<int,int>(new CustomComparer()); 
        var resultList = new List<int>(); 
        
        // Does this user have any tweets to get?
        if (userTweetsDict.ContainsKey(userId)) { 
            var allTheUsersTweets = userTweetsDict[userId].UnorderedItems; 
            allResults.EnqueueRange(allTheUsersTweets);
        }
        
        // Does any user this user follows have tweets?
        if (userFollowsDict.ContainsKey(userId)) {
            foreach(var followee in userFollowsDict[userId]) {
                // get all their tweets 
                if (userTweetsDict.ContainsKey(followee)) {
                    var allFolloweeTweets = userTweetsDict[followee].UnorderedItems; 
                    allResults.EnqueueRange(allFolloweeTweets);
                }
            }
        }
        
        // all results are combined into a single priority queue
        var topTenResults = 10; 
        while (allResults.Count > 0 && topTenResults > 0) {;
            resultList.Add(allResults.Dequeue()); 
            topTenResults--; 
        }
        
        return resultList; 
    }
    
    public void Follow(int followerId, int followeeId) {
        if (userFollowsDict.ContainsKey(followerId)) {
            if (!userFollowsDict[followerId].Contains(followeeId)) {
                userFollowsDict[followerId].Add(followeeId); 
            }
        } else {
            userFollowsDict.Add(followerId, new HashSet<int> {followeeId} ); 
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (userFollowsDict.ContainsKey(followerId)) {
            if (userFollowsDict[followerId].Contains(followeeId)) {
                userFollowsDict[followerId].Remove(followeeId); 
            }
        }
    }
}