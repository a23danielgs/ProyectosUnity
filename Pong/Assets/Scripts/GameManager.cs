using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool running = false;
    public static int p1Score;
    public static int p2Score;
    [SerializeField] TMP_Text txtP1Score;
    [SerializeField] TMP_Text txtP2Score;
    [SerializeField] GameObject pelota; 
    
    public void AddPointP1() { 
        p1Score++; 
        if (p1Score==10)
        {
            SceneManager.LoadScene(2);
        }
        txtP1Score.text = p1Score.ToString();
    }
    public void AddPointP2() {
        p2Score++;
        if (p2Score==10)
        {
            SceneManager.LoadScene(2);
        }
        txtP2Score.text = p2Score.ToString();
    }
    void Start()
    {
        Cursor.visible = false;
    }
    void Update(){
        if(!running){
            // Activamos la pelota 
            pelota.SetActive(true);
            // Indicamos que el juego ha comenzado
            running = true; 
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            running = false; 
            Application.Quit();
        }
    }

    public static void ResetGame()
    {
        p1Score=0;
        p2Score=0;
        SceneManager.LoadScene(0);
    }
}
