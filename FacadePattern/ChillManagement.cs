namespace DesignPattern.FacadePattern;

public class ChillManagement
{
    private Coffee _coffee;
    private PC _pc;
    private Mouse _mouse;
    private Keyboard _keyboard;
    
    public ChillManagement()
    {
        _coffee = new Coffee();
        _pc = new PC();
        _mouse = new Mouse();
        _keyboard = new Keyboard();
    }

    public void Start()
    {
        _coffee.Cup();
        _coffee.MakeCoffee();
        _pc.TurnOn();
        _pc.Login();
        _mouse.StartBrowser();
        _mouse.Adressbar();
        _keyboard.GoToCodingBuddiesStream();
    }
}