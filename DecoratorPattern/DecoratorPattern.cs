namespace DesignPattern.DecoratorPattern;

/*
 * Component: IBurger
 * ConcreteComponent: Hamburger / Cheeseburger
 * Decorator: BurgerAddon
 * ConcreteDecoratorA:Onion
 * ConcreteDecoratorB:Jalapeno
 *
 */

public static class DecoratorPattern
{
    public static void Start()
    {
        Hamburger hamburger = new Hamburger();
        Onion hamburgerWithOnion = new Onion(hamburger);
        Jalapeno hamburgerWithJalapeno = new Jalapeno(hamburgerWithOnion);

        Console.WriteLine(hamburgerWithJalapeno.GetDescription());
        Console.WriteLine("Der Burger hat " + hamburgerWithJalapeno.GetCalories() + " Kalorien");
        Console.WriteLine("Der Burger kostet: " + hamburgerWithJalapeno.GetPrice()+ " Euro");
        
    }
}