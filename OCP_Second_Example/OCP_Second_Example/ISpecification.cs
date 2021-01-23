namespace OCP_Second_Example
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
