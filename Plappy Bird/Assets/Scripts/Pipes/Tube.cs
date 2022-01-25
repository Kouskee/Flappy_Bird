using System;
using UnityEngine;

public class Tube : MonoBehaviour, IPooledObject
{
    [SerializeField] private float speedPipes = -6f;
    
    private IPoolReturn _poolReturn;

    public bool OnObjectSpawn()
    {
        return true;
    }

    private void Update()
    {
        if(OnObjectSpawn())
            transform.position += Vector3.right * speedPipes * Time.deltaTime;
    }

    public void AssignPool(IPoolReturn pool)
    {
        _poolReturn = pool;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<TubeDestroyer>(out var tubeDestroyer))
            _poolReturn.ReturnToPool(this);
    }

    public void Enable()
    {
        gameObject.SetActive(true);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }
}