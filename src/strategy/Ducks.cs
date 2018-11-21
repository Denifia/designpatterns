using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace strategy
{
    public interface IDuck
    {
        // Good place to use Interface Segregation Principle i.e. ICanQuack, ICanEat
        string Quack();
        void Eat();
        void ChangeQuackStrategy(IQuackStrategy quackStrategy);
    }

    public abstract class Duck : IDuck
    {
        private IQuackStrategy _quackStrategy;
        private readonly IEatStrategy _eatStrategy;

        protected Duck(IQuackStrategy quackStrategy, IEatStrategy eatStrategy)
        {
            _quackStrategy = quackStrategy;
            _eatStrategy = eatStrategy;
        }

        public string Quack() => _quackStrategy.Quack();

        public void Eat() => _eatStrategy.Eat();

        public void ChangeQuackStrategy(IQuackStrategy quackStrategy)
        {
            _quackStrategy = quackStrategy;
        }
    }

    public class CityDuck : Duck
    {
        public CityDuck()
            : base(new NormalQuackStrategy(), new GreedyEatStrategy()) // Good place to use DI
        {

        }
    }

    public class ForrestDuck : Duck
    {
        public ForrestDuck() 
            : base(new LoudQuackStrategy(), new NormalEatStrategy()) // Good place to use DI
        {

        }
    }

    public class RiverDuck : Duck
    {
        public RiverDuck() 
            : base(new NormalQuackStrategy(), new NormalEatStrategy()) // Good place to use DI
        {

        }
    }
}
