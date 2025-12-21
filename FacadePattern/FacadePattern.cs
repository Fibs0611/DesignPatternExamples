namespace DesignPattern.FacadePattern;


/*client: FacadePattern
 * Facade: ChillManager
 * Subsystem: Coffee / PC / Mouse / Keyboard
 */

public static class FacadePattern
{
    public static void Start()
    {
        ChillManagement chill =  new ChillManagement();
        chill.Start();
    }
}