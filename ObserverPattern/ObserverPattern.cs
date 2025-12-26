namespace DesignPattern.ObserverPattern;
/*
 * Subject: PodcastSubject
 * Concrete Subject: CodingBuddiesPodcast
 * Observer: IPodcastObserver
 * Concrete Observer: Buddies
 */


public static class ObserverPattern
{
    public static void Start()
    {
        CodingBuddiesPodcast cb = new CodingBuddiesPodcast(new Podcast("Erster Podcast", "Wer sind wir"));

        Buddies buddies1 = new Buddies("Fibs");
        Buddies buddies2 = new Buddies("Fibs2008");
        Buddies buddies3 = new Buddies("David");
        
        cb.Subscribe(buddies1);
        cb.Subscribe(buddies2);
        
        cb.SetPodcast(new Podcast("Oberser Pattern", "Was ist ein Oberserpattern"));
        
        cb.Unsubscribe(buddies1);
        cb.Subscribe(buddies3);
        
        cb.SetPodcast(new Podcast("DevOps", "Was macht ein DevOps"));
        

    }
}