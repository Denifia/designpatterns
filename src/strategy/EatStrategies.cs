using System;
using System.Collections.Generic;
using System.Text;

namespace strategy
{
    public interface IEatStrategy
    {
        void Eat();
    }

    public class NormalEatStrategy : IEatStrategy
    {
        public void Eat()
        {
            // Eat some of the food
        }
    }

    public class GreedyEatStrategy : IEatStrategy
    {
        public void Eat()
        {
            // Eat all of the food
        }
    }
}
