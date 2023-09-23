namespace SimUDuck
{
    /// <summary>
    /// Утки которые умеют крякать
    /// </summary>
    public class MallardDuck : Duck
    {
        public MallardDuck(string name) : base(name)
        {
            
        }
   
        public override void Display()
        {
            Console.WriteLine($"Я - {Name}");
        }
    }
}

