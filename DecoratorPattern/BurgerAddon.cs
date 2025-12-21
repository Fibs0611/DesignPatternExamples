namespace DesignPattern.DecoratorPattern;

public abstract class BurgerAddon : IBurger
{
    protected IBurger burger;

    public BurgerAddon(IBurger burger)
    {
        this.burger = burger;
    }

    public abstract string GetDescription();
    public abstract double GetPrice();
    public abstract int GetCalories();
    
}