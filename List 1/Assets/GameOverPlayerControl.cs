using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPlayerControl : MonoBehaviour
{

    public bool gameOver = false;
    private bool restartPending = false;
    void Update()
    {
        if (transform.position.y < -10f)
        {
            gameOver = true;
        }

        if (gameOver && !restartPending)
        {
            Invoke("Restart", 2f);
            restartPending = true;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quitting");
            Application.Quit();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        restartPending = false;
        gameOver = false;
    }
}
