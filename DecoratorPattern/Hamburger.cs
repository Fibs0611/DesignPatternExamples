namespace DesignPattern.DecoratorPattern;

public class Hamburger : IBurger
{
    public string GetDescription()
    {
        return "Hamburger \n Basis \n";
    }

    public double GetPrice()
    {
        return 3.99;
    }

    public int GetCalories()
    {
        return 99;
    }
}