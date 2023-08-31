namespace PetshopC_
{
    internal abstract class Animal
    {
        public Guid Id { get; set; }

        private string nickname;
        public string Nickname { get { return nickname; } set { nickname = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        private string gender;
        public string Gender { get { return gender; } set { gender = value; } }

        private int energy;
        public int Energy { get { return energy; } set { energy = value; } }

        private double price;
        public double Price { get { return price; } set { price = value; } }

        private int mealquantity;
        public int MealQuantity { get { return mealquantity; } set { mealquantity = value; } }

        public Animal(string nickname,int age,string gender,double price)
        {
            Id = Guid.NewGuid();
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = 100;
            Price = price;
            MealQuantity = 0;

        }


        public virtual void Eat()
        {
            MealQuantity++;
            Price += 10;

            if(Energy < 100)
                Energy++;

            else
                new Exception("Your pet can't eat.Energy is full");
        }

        public virtual void Sleep()
        {
            if (Energy < 100)
                Energy++;

            else
                new Exception("Your pet can't sleep.Energy is full");
        }

        public virtual void Play()
        {
            if (Energy > 0)
                Energy--;
            else
                new Exception("Your pet can't play.Boost energy");
        }

        public virtual void Print()
        {
            Console.WriteLine($"Nickname: {Nickname}\nAge: {Age}\nGender: {Gender}\nPrice: {Price}\nEnergy: {Energy}\nMealQuantity: {MealQuantity}");
        }
    }
}
