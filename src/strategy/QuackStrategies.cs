namespace strategy
{
    public interface IQuackStrategy
    {
        string Quack();
    }

    public class NormalQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Quack";
        }
    }

    public class LoudQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "QUACK!!";
        }
    }
}
