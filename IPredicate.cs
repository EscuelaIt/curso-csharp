namespace ConsoleDrawer { 
    public interface IPredicate<T> {
        bool Match(T item);
    }

    public class PredicateIntOdd : IPredicate<int>
    {
        public bool Match(int item)
        {
            return item % 2 == 0;
        }
    }
}