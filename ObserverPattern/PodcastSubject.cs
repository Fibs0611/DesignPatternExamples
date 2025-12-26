namespace DesignPattern.ObserverPattern;

public abstract class PodcastSubject
{
    private List<IPodcastObserver> observers = new List<IPodcastObserver>();

    public void Subscribe(IPodcastObserver observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
            
        }
    }

    public void Unsubscribe(IPodcastObserver observer)
    {
        if (observers.Contains(observer)){
            observers.Remove(observer);
        }
    }

    public void SendPodcast(Podcast podcast)
    {
        foreach (IPodcastObserver po in observers)
        {
            po.Update(podcast);
        }
    }
}