namespace SimUDuck
{
    /// <summary>
    /// Утки которые крякают
    /// </summary>
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Умею крякать");
        }
    }
}

