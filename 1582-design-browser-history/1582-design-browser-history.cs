public class BrowserHistory
{
    private BrowserPage _browserPage;

    public BrowserHistory(string homepage)
    {
        _browserPage = new BrowserPage(homepage, null, null);
    }
    
    public void Visit(string url)
    {
        _browserPage.Next = new BrowserPage(url, _browserPage, null);
        _browserPage = _browserPage.Next;
    }
    
    public string Back(int steps)
    {
        while (steps > 0 && _browserPage.Prev != null)
        {
            _browserPage = _browserPage.Prev;
            steps -= 1;
        }

        return _browserPage.URI;
    }
    
    public string Forward(int steps) {
        while (steps > 0 && _browserPage.Next != null)
        {
            _browserPage = _browserPage.Next;
            steps -= 1;
        }

        return _browserPage.URI;
    }
}

public class BrowserPage
{
    public BrowserPage(string uri, BrowserPage prev, BrowserPage next)
    {
        Prev = prev;
        URI = uri;
        Next = next;
    }

    public BrowserPage Prev { get; set; }
    public string URI { get; set; }
    public BrowserPage Next { get; set; }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */