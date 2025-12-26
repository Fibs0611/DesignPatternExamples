namespace DesignPattern.ObserverPattern;

public class CodingBuddiesPodcast : PodcastSubject
{
    private Podcast _podcast;

    public CodingBuddiesPodcast(Podcast podcast)
    {
        _podcast = podcast;
    }

    public void GetPodcast()
    {
        Console.WriteLine(_podcast);
    }

    public void SetPodcast(Podcast podcast)
    {
        _podcast = podcast;
        SendPodcast(_podcast);
    }
    
    
}