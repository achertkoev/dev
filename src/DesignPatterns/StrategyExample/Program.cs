using SimUDuck;

var ducks = new List<Duck>()
{
    new MallardDuck("крякающая утка"),
    new RedheadDuck("рыжая утка")
};

foreach (var duck in ducks)
{
    duck.Display();
    duck.Swim();
    duck.Quack();
    Console.WriteLine();
}