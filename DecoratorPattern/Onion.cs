namespace DesignPattern.DecoratorPattern;

public class Onion : BurgerAddon
{
    public Onion(IBurger burger) : base(burger)
    { }

    public override string GetDescription()
    {
        return burger.GetDescription() + " mit zusätzlich Zwiebeln \n ";
    }

    public override double GetPrice()
    {
        return burger.GetPrice()+ 0.5;
    }

    public override int GetCalories()
    {
        return burger.GetCalories() + 10;
    }
}