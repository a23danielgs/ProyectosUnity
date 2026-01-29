using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variable para llevar el control de la puntuación
    public static int Score { get; private set; } = 0; 
    public static int Lives { get; private set; } = 5;
    public static int[] totalBricks = new int[]{0, 28, 19};
    
    // Método para actualizar la puntuación
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
    public static void UpdateScore(int points){
        Score += points;
    }
    public static void Updatelives(){
        Lives--;
    }
    public static void ResetGame()
    {
        Score = 0;

        Lives = 5;

        SceneManager.LoadScene(0);
    }
}