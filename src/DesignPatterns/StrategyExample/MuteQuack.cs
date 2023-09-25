namespace SimUDuck
{
    /// <summary>
    /// Резиновые утки пищат
    /// </summary>
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Не умею крякать");
        }
    }
}

