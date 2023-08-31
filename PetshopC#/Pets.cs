using System.Diagnostics;
using System.Drawing;

namespace PetshopC_
{
    internal class Cat:Animal
    {
        private string color;
        public string Color { get { return color; } set { color = value; } }

        public Cat(string nickname, int age, string gender, double price, string color):base(nickname,age,gender,price)
        {
            Color = color;
        }

        public override void Eat()
        {
            if (Energy == 0)
                new Exception("Cats energy is 0.Cat must sleep");
            else
                base.Eat();
       
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void Play()
        {
            if (Energy == 0)
                new Exception("Cats energy is 0.Cat must sleep");
            else
                base.Play();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Color: {Color}\n");
        }

    }

    internal class Dog : Animal
    {
        private double height;
        public double Height { get { return height; } set { height = value; } }

        public Dog(string nickname, int age, string gender, double price, double height) : base(nickname, age, gender, price)
        {
            Height = height;
        }

        public override void Eat()
        {
            base.Eat();
            Height += 0.1;

        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Height: {Height} m\n");
        }
    }


    internal class Bird : Animal
    {
        private double speed;
        public double Speed { get { return speed; } set { speed = value; } }

        public Bird(string nickname, int age, string gender, double price, double speed) : base(nickname, age, gender, price)
        {
            double Speed = speed;
        }

        public override void Eat()
        {
            base.Eat();
            Speed += 0.15;

        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Speed: {Speed} km/h\n");
        }
    }


    internal class Fish : Animal
    {
        private bool isHealthy;
        public bool IsHealthy { get { return isHealthy; } set { isHealthy = value; } }

        public Fish(string nickname, int age, string gender, double price, bool isHealthy) : base(nickname, age, gender, price)
        {
            bool IsHealthy = isHealthy;
        }

        public override void Eat()
        {
            base.Eat();

        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"IsHealthy: {IsHealthy}\n");
        }
    }
}
