namespace SimUDuck
{
    
    /// <summary>
    /// Утка
    /// </summary>
    public abstract class Duck
    {
        public string Name { get; }

        public Duck(string name)
        {
            Name = name;
        }
    
        /// <summary>
        /// Утка крякает
        /// </summary>
        /// <returns></returns>
        public void Quack()
        {
            Console.WriteLine("умею крякать");
        }

        /// <summary>
        /// Утка плавает
        /// </summary>
        /// <returns></returns>
        public void Swim()
        {
            Console.WriteLine("умею плавать");
        }

        /// <summary>
        /// Отображение утки
        /// </summary>
        /// <returns></returns>
        public abstract void Display();
    }
}
