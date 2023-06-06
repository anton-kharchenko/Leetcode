public class Codec {
    Dictionary<string, string> dic = new Dictionary<string, string>();
    string body = "http://tinyurl.com/";
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        var hash = new Random();
        var tinyUrl = body + hash.Next(0, 10000000).ToString();
        
        while(dic.ContainsKey(tinyUrl)){
            tinyUrl = body + hash.Next(0, 10000000).ToString();
        }
        
        if(!dic.ContainsKey(tinyUrl)){
            dic.Add(tinyUrl, longUrl);
        }
        
        return tinyUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        if(dic.ContainsKey(shortUrl)){
            return dic[shortUrl];
        }
        
        return string.Empty;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));