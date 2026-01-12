namespace Task1
{
    internal class Program
    {
        public abstract class Vehicle
        {
            public string? Name { get; set; }

            public virtual string Stop()
            {
                return $"{Name} engine stopped.";
            }
            public virtual string Start()
            {
                return $"{Name} engine stopped.";
            }
        }


        public class Car : Vehicle
        {
           
            public Car(string name)
            {
                Name = name;
            }
            public Car()
            {
                Name = "";
            }
            public sealed override string Start()
            {
                return $"{Name} car engine started";
            }
        }
        public class Motorcycle : Vehicle
        {
            public Motorcycle()
            {
                Name = "";
            }

            public Motorcycle(string name)
            {
                Name = name;
            }

            public sealed override string Start()
            {
                return $"{Name} motorcycle engine started";
            }
        }

        static void Main(string[] args)
        {
            Vehicle[] vehicles = {
                new Car("Toyota"),
                new Motorcycle("Honda")
            };

            foreach(Vehicle v in vehicles)
            {
                Console.WriteLine(v.Start()+ ", "+v.Stop());
            }
        }
    }
}
