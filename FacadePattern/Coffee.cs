namespace DesignPattern.FacadePattern;

public class Coffee
{
    public void Cup()
    {
        Console.WriteLine("Holt die Tasse aus dem Regal und stellt sie unter die Kaffeemaschine");
    }

    public void MakeCoffee()
    {
        Console.WriteLine("Macht einen fantastischen Kaffee");
    }
}