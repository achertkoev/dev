namespace SimUDuck;

/// <summary>
/// Летать на крыльях
/// </summary>
public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Умею летать на крылях");
    }
}