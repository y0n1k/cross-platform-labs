using System;

namespace MyInterface
{
    class Program {

        static void Main(string[] args) { 
            
            Sheep sheep1 = new Sheep("Sheep1");
            Sheep sheep2 = new Sheep("Sheep2");
            Wolf wolf1 = new Wolf("Wolf1");
            Wolf wolf2 = new Wolf("Wolf2");
            Turtle turtle = new Turtle("Little turtle");

            Console.WriteLine($"{wolf1.Name} and {wolf2.Name} went for a hunt");
            Console.WriteLine($"{wolf1.Name} and {wolf2.Name} spotted {sheep1.Name} and {sheep2.Name}");
            wolf1.Hunt();
            sheep2.Run();
            
            turtle.Hunt();
            turtle.Run();
        }

        interface IPredator {
            void Hunt();
        }
        interface IPrey { 
            void Run();

        }
        class Sheep : IPrey
        {
            public string Name { get; }
            public Sheep(string name)
            {
                Name = name;
            }

            public void Run ()
            {
                
                Console.WriteLine($"{Name} has run away");
            }
        }
        class Wolf : IPredator
        {
            public string Name { get; }
            public Wolf(string name)
            {
                Name = name;
            }

            public void Hunt()
            {
                Console.WriteLine($"{Name} has caught a prey");
            }
        }
        class Turtle: IPredator, IPrey
        {
            public string Name { get; }
            public Turtle(string name)
            {
                Name = name;
            }

            public void Run()
            {
                Console.WriteLine($"{Name} has swum away");
            }

            public void Hunt()
            {
                Console.WriteLine($"{Name} has caught a fish");
            }
        }
    }
}