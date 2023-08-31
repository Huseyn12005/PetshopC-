using PetshopC_;

Cat c_1 = new Cat("Messi", 15, "Male", 100, "Black");
Cat c_2 = new Cat("Penaldo", 13, "Male", 50, "White");

Cat[] cats = new Cat[] { c_1, c_2 };

Dog d_1 = new Dog("Boz", 5, "Female", 1254, 1.5);
Dog d_2 = new Dog("Rex", 3, "Male", 1000, 2.0);

Dog[] dogs = new Dog[] { d_1, d_2 };

Bird b_1 = new Bird("Serce", 7, "Female", 35, 43.5);
Bird b_2 = new Bird("Qarqa", 27, "Male", 24, 50);

Bird[] birds = new Bird[] { b_1, b_2 };

Fish f_1 = new Fish("QizilBalig", 11, "Female", 1254, true);
Fish f_2 = new Fish("Akula", 150, "Female", 1000, false);

Fish[] fishes = new Fish[] { f_1, f_2 };

PetShop petshop = new PetShop(cats, dogs, birds, fishes);

petshop.Print();