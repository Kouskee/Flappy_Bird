using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour, IPoolObject
{
    [SerializeField] private float speedPipes = -6f;

    public bool OnObjectSpawn()
    {
        return true;
    }

    private void Update()
    {
        if(OnObjectSpawn())
            transform.position += Vector3.right * speedPipes * Time.deltaTime;

    }
}
