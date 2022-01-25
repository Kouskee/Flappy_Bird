using System.Collections.Generic;

public class Pool<T> : IPoolReturn where T : IPooledObject
{
    private readonly Queue<T> _inactiveObjects;

    public Pool()
    {
        _inactiveObjects = new Queue<T>();
    }
    
    public void AddObject(T obj)
    {
        obj.AssignPool(this);
    }

    public T GetInactiveObject()
    {
        var obj = _inactiveObjects.Dequeue();
        obj.Enable();
        return obj;
    }

    public bool HasInactiveObj()
    {
        return _inactiveObjects.Count > 0;
    }

    public void ReturnToPool(IPooledObject obj)
    {
        obj.Disable();
        _inactiveObjects.Enqueue((T)obj);
    }
}