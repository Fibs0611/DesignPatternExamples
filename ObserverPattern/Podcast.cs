namespace DesignPattern.ObserverPattern;

public class Podcast
{
    public string Title { get; set; }
    public string Description { get; set; }
    
    public Podcast(string title, string description)
    {
        Title = title;
        Description = description;
    }

    override public string ToString()
    {
        return $"{Title} - {Description}";
    }
    
}