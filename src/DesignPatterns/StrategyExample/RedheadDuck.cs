namespace SimUDuck
{
    /// <summary>
    /// Рыжая утка
    /// </summary>
    public class RedheadDuck : Duck
    {
        public RedheadDuck(string name) : base(name)
        {
            
        }
        
        public override void Display()
        {
            Console.WriteLine($"Я - {Name}");
        }
    }
}
