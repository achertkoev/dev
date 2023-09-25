namespace SimUDuck
{
    
    /// <summary>
    /// Утка
    /// </summary>
    public abstract class Duck 
    {
        protected string Name { get; }
        private IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;

        protected Duck(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Выполнить кряк
        /// </summary>
        public void PerformQuack()
        {
            if(_quackBehavior is not null)
                _quackBehavior.Quack();
        }
        
        /// <summary>
        /// Выполнить полет
        /// </summary>
        public void PerformFly()
        {
            if(_flyBehavior is not null)
                _flyBehavior.Fly();
        }

        /// <summary>
        /// Установить поведения кряка
        /// </summary>
        /// <param name="quackBehavior"></param>
        public void SetQuackBehavior(IQuackBehavior quackBehavior) => _quackBehavior = quackBehavior;
        
        /// <summary>
        /// Установить поведение полета
        /// </summary>
        /// <param name="flyBehavior"></param>
        public void SetFlyBehavior(IFlyBehavior flyBehavior) => _flyBehavior = flyBehavior;
        
        /// <summary>
        /// Отображение утки
        /// </summary>
        /// <returns></returns>
        public virtual void Display()
        {
            Console.WriteLine($"Я - {Name}");
        }
    }
}
