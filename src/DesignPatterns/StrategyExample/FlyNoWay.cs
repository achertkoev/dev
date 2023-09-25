namespace SimUDuck;

/// <summary>
/// Не летает
/// </summary>
public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Не умею летать");
    }
}