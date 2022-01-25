public interface IPooledObject
{
    void AssignPool(IPoolReturn pool);

    void Enable();
    void Disable();
}