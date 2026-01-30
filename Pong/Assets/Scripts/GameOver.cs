using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI P1;
    [SerializeField] TextMeshProUGUI P2;

    bool gameOver = false;

    void Update()
    {
        if (!gameOver && GameManager.p1Score==10)
        {
            P1.gameObject.SetActive(true);
            gameOver = true;
        }

        if (!gameOver && GameManager.p2Score==10)
        {
            P2.gameObject.SetActive(true);
            gameOver = true;
        }

        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.ResetGame();
        }
    }
}