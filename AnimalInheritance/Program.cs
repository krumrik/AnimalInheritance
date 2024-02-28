using System;

namespace SimpleInheritance
{
    class Animal
    {
        private string name; 
        protected string type; 
        public string color;  

        public void setName(string name)
        {
            this.name = name;
        }

        public virtual string getName()
        {
            return this.name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public virtual string getType()
        {
            return this.type;
        }
    }

    class Cat : Animal
    {
        private double weight; 
        private double height; 
        protected string breed; 

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public double getWeight()
        {
            return weight;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public string getBreed()
        {
            return breed;
        }

        public override string getName()
        {
            return $"Name = {base.getName()}";
        }

        public override string getType()
        {
            return $"Type = {base.getType()}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();

            Console.WriteLine("Animal Information");
            myAnimal.setName("Sparky");
            myAnimal.setType("Dog");
            myAnimal.color = "White";

            Console.WriteLine($"Name = {myAnimal.getName()}");
            Console.WriteLine($"Type = {myAnimal.getType()}");
            Console.WriteLine($"Color = {myAnimal.color}");

            Console.WriteLine();

            Cat myCat = new Cat();

            Console.WriteLine("Horse Information");
            myCat.setName("Sam");
            myCat.setType("Horse");
            myCat.color = "Black";
            myCat.setBreed("Stallion");
            myCat.setHeight(7);
            myCat.setWeight(1500);

            Console.WriteLine(myCat.getName());
            Console.WriteLine(myCat.getType());
            Console.WriteLine($"Color = {myCat.color}");
            Console.WriteLine($"Breed = {myCat.getBreed()}");
            Console.WriteLine($"Height = {myCat.getHeight()}");
            Console.WriteLine($"Weight = {myCat.getWeight}");
        }
    }
}