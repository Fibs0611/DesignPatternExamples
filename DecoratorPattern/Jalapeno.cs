namespace DesignPattern.DecoratorPattern;

public class Jalapeno : BurgerAddon
{
    public Jalapeno(IBurger burger) : base(burger)
    {
    }

    public override string GetDescription()
    {
        return burger.GetDescription() + "mit zusätzlich Jalapenos \n ";
    }

    public override double GetPrice()
    {
        return burger.GetPrice()+ 1;
    }

    public override int GetCalories()
    {
        return burger.GetCalories() + 15;
    }
}