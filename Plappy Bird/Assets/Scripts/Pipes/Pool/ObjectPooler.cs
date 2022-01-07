using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string _tag;
        public GameObject _prefab;
        public int _size;
    }

    #region Singleton

    public static ObjectPooler Instance;
    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public List<Pool> _pools;
    public Dictionary<string, Queue<GameObject>> _poolDictionary;

    private void Start()
    {
        _poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in _pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool._size; i++)
            {
                GameObject obj = Instantiate(pool._prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }
            _poolDictionary.Add(pool._tag, objectPool);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!_poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Пула с именем " + tag + " нет.");
                return null;
        }

        GameObject objectToSpawn = _poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        IPoolObject poolObject = objectToSpawn.GetComponent<IPoolObject>();
        if (poolObject != null)
            poolObject.OnObjectSpawn();

        _poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    } 
}
