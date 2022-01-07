using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    private ObjectPooler _pooler;
    private Vector3 _positionTube = Vector3.zero;
    private Timer _timer;

    private const float _tubeLower = -2.5f, _tupeUpper = 2.5f;

    void Start()
    {
        _pooler = ObjectPooler.Instance;
        _positionTube = _spawnPoint.position;

        StartTimer();
    }

    private void StartTimer()
    {
        _timer = new Timer(3f);
        _timer.TimeAgain += OnTimeAgain;
    }

    private void OnTimeAgain()
    {
        SpawnTube();
        _timer.Reset();
    }

    public void SpawnTube()
    {
        _positionTube.y = Random.Range(_tubeLower, _tupeUpper);

        _pooler.SpawnFromPool("Tube", _positionTube, Quaternion.identity);
    }

    private void Update()
    {
        _timer.Update(Time.deltaTime);
    }
}
