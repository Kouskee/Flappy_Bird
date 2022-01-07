using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform _bird;

    void Update()
    {
        if (_bird.position.y >= 8f || _bird.position.y <= -7f || _bird.position.x <= -14f || _bird.position.x >= 14f)
            Restart();
    }

    public void EndGame()
    {
        Invoke("Restart", 0.5f);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
