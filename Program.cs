using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.Name = "Dog";
            animal1.Traits = "Friendly";
            animal1.Teeth = "Sharp";
            animal1.WhoAmI();
            Rectangle r = new Rectangle(12, 3);
            r.CalculatePerimeter();

            Rectangle r2 = new Rectangle();
            Rectangle r3= new Rectangle( "slkfsdl","slkfsdl" );
            
        }
    }

    class Animal
    {
        public string? Name {get; set;}
        public string? Traits {get; set;}
        public string? Teeth {get; set;}

        public void Cry()
        {
            Console.WriteLine("Woof!");
        }

        public void WhoAmI()
        {
            if(Name != null) Console.WriteLine("I am "+Name);

            if(Traits != null) Console.WriteLine("My Traits are "+Traits);

            if(Teeth != null) Console.WriteLine("I have a "+Teeth+" teeth");
            
    
        }
    }
}