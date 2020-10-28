namespace OCP_Second_Example_Practice
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}