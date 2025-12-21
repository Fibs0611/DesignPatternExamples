namespace DesignPattern.DecoratorPattern;

public class Cheeseburger : IBurger
{
    public string GetDescription()
    {
        return "Cheesebruger \n Basis \n ";
    }

    public double GetPrice()
    {
        return 4.99;
    }

    public int GetCalories()
    {
        return 124;
    }
}