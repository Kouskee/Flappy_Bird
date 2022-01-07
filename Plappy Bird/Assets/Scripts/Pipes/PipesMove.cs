using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMove : MonoBehaviour, IPoolObject
{
    private float speedPipes = -6f;

    public bool OnObjectSpawn()
    {
        return true;
    }

    void Update()
    {
        if(OnObjectSpawn())
            this.transform.position += Vector3.right * speedPipes * Time.deltaTime;

    }
}
