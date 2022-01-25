using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnTube : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Tube _tube;
    private Pool<Tube> _pool;
    private Timer _timer;

    private const float _tubeLower = -2.5f, _tupeUpper = 2.5f;

    private void Awake()
    {
        _pool = new Pool<Tube>();
    }

    private void Start()
    {
        StartTimer();
        
        OnTimesUp();
    }

    private void StartTimer()
    {
        _timer = new Timer(3f);
        _timer.TimeAgain += OnTimesUp;
    }

    private void OnTimesUp()
    {
        var tube = GetTube();
        PlaceTube(tube);
        _timer.Reset();
    }

    private Tube GetTube()
    {
        return _pool.HasInactiveObj() ? _pool.GetInactiveObject() : CreateNewTube();
    }

    private Tube CreateNewTube()
    {
        var tube = Instantiate(_tube);
        _pool.AddObject(tube);
        return tube;
    }

    public void PlaceTube(Tube tube)
    {
        var y = Random.Range(_tubeLower, _tupeUpper);
        tube.transform.position = new Vector3(_spawnPoint.position.x, y, _spawnPoint.position.z);
    }

    private void Update()
    {
        _timer.Update(Time.deltaTime);
    }
}