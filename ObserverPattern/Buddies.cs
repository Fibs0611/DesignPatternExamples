namespace DesignPattern.ObserverPattern;

public class Buddies : IPodcastObserver
{
    private string _name;
    private Podcast _currentPodcast;
    
    public Buddies(string name)
    {
        _name = name;
    }

    public void Update(Podcast podcast)
    {
        _currentPodcast = podcast;
        Console.WriteLine(_name + " hat die Benachrichtigung das es einen neunen Podcast mit dem Titel: " + podcast.Title + " erhalten.");
    }
}