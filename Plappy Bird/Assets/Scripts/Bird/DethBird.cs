using UnityEngine;

public class DethBird : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private LayerMask _tubeMask;

    private Timer _timer;
    private bool _IsEndGame = false;

    private void DelayEndGame()
    {
        _IsEndGame = true;
        _timer = new Timer(0.5f);
        _timer.TimeAgain += OnTimeIsUp;
    }

    private void OnTimeIsUp()
    {
        _gameManager.Restart();
        _timer.TimeAgain -= OnTimeIsUp;
        _IsEndGame = false;
    }

    private void Update()
    {
        if(_IsEndGame)
            _timer.Update(Time.deltaTime);

        if (Physics.CheckSphere(transform.position, 0.6f, _tubeMask))
        {
            DelayEndGame();
        }
    }
}
