namespace SimUDuck
{
    /// <summary>
    /// Резиновые утки пищат
    /// </summary>
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Умею издавать писк");
        }
    }
}

