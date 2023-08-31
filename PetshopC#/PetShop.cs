namespace PetshopC_
{
    internal class PetShop
    {
        public Cat[] Cats { get; set; }
        public Dog[] Dogs { get; set; }
        public Bird[] Birds { get; set; }
        public Fish[] Fishes { get; set; }


        public PetShop(Cat[] cats, Dog[] dogs, Bird[] birds, Fish[] fishes)
        {
            Cats = cats;
            Dogs = dogs;
            Birds = birds;
            Fishes = fishes;
        }

        public void RemoveByNickNameCat(string nickname)
        {
            Cat[] newArray = new Cat[Cats.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Cats.Length; i++)
            {
                if (Cats[i].Nickname != nickname)
                {
                    newArray[newArrayIndex] = Cats[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByNickNameDog(string nickname)
        {
            Dog[] newArray = new Dog[Dogs.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Dogs.Length; i++)
            {
                if (Dogs[i].Nickname != nickname)
                {
                    newArray[newArrayIndex] = Dogs[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByNickNameBird(string nickname)
        {
            Bird[] newArray = new Bird[Birds.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Birds.Length; i++)
            {
                if (Birds[i].Nickname != nickname)
                {
                    newArray[newArrayIndex] = Birds[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByNickNameFish(string nickname)
        {
            Fish[] newArray = new Fish[Fishes.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Fishes.Length; i++)
            {
                if (Fishes[i].Nickname != nickname)
                {
                    newArray[newArrayIndex] = Fishes[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByIdCat(Guid id)
        {
            Cat[] newArray = new Cat[Cats.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Cats.Length; i++)
            {
                if (Cats[i].Id != id)
                {
                    newArray[newArrayIndex] = Cats[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByIdDog(Guid id)
        {
            Dog[] newArray = new Dog[Dogs.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Dogs.Length; i++)
            {
                if (Dogs[i].Id != id)
                {
                    newArray[newArrayIndex] = Dogs[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByIdBird(Guid id)
        {
            Bird[] newArray = new Bird[Birds.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Birds.Length; i++)
            {
                if (Birds[i].Id != id)
                {
                    newArray[newArrayIndex] = Birds[i];
                    newArrayIndex++;
                }
            }
        }

        public void RemoveByIdFish(Guid id)
        {
            Fish[] newArray = new Fish[Fishes.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < Fishes.Length; i++)
            {
                if (Fishes[i].Id != id)
                {
                    newArray[newArrayIndex] = Fishes[i];
                    newArrayIndex++;
                }
            }
        }

        public void ChangeNicknameByIdCat(Guid id, string nickname)
        {
            foreach(Cat item in Cats)
            {
                if(item.Id == id)
                {
                    item.Nickname = nickname;
                    break;
                }
            }
        }

        public void ChangeNicknameByIdDog(Guid id, string nickname)
        {
            foreach (Dog item in Dogs)
            {
                if (item.Id == id)
                {
                    item.Nickname = nickname;
                    break;
                }
            }
        }

        public void ChangeNicknameByIdBird(Guid id, string nickname)
        {
            foreach (Bird item in Birds)
            {
                if (item.Id == id)
                {
                    item.Nickname = nickname;
                    break;
                }
            }
        }

        public void ChangeNicknameByIdFish(Guid id, string nickname)
        {
            foreach (Fish item in Fishes)
            {
                if (item.Id == id)
                {
                    item.Nickname = nickname;
                    break;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Cats");
            foreach (Cat item in Cats)
            {
                item.Print();
            }
            Console.WriteLine();
            Console.WriteLine("Dogs");
            foreach (Dog item in Dogs)
            {
                item.Print();
            }
            Console.WriteLine();
            Console.WriteLine("Birds");
            foreach (Bird item in Birds)
            {
                item.Print();
            }
            Console.WriteLine();
            Console.WriteLine("Fishes");
            foreach (Fish item in Fishes)
            {
                item.Print();
            }
        }
    }
}
