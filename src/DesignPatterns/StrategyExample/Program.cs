using SimUDuck;

var mallardDuck = new MallardDuck(nameof(MallardDuck));
var redheadDuck = new RedheadDuck(nameof(RedheadDuck));
var rubberDuck = new RubberDuck(nameof(RubberDuck));

mallardDuck.Display();
mallardDuck.PerformQuack();
mallardDuck.SetFlyBehavior(new FlyNoWay());
mallardDuck.PerformFly();
Console.WriteLine();

redheadDuck.Display();
redheadDuck.PerformQuack();
redheadDuck.PerformFly();
redheadDuck.SetFlyBehavior(new FlyWithWings());
redheadDuck.PerformFly();
redheadDuck.SetFlyBehavior(new FlyNoWay()); 
redheadDuck.PerformFly();
Console.WriteLine();

rubberDuck.Display();
rubberDuck.SetQuackBehavior(new Squeak());
rubberDuck.PerformQuack();
Console.WriteLine();