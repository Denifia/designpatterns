using System;
using System.Collections.Generic;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck cityDuck = new CityDuck();
            IDuck forrestDuck = new ForrestDuck();
            IDuck riverDuck = new RiverDuck();

            DoDuckThings(cityDuck);
            DoDuckThings(forrestDuck);
            DoDuckThings(riverDuck);

            riverDuck.ChangeQuackStrategy(new LoudQuackStrategy());
            DoDuckThings(riverDuck);

            Console.ReadKey();
        }

        private static void DoDuckThings(IDuck duck)
        {
            Console.WriteLine($"{duck.GetType().Name}: {duck.Quack()}");
            duck.Eat();
        }
    }

    

}
