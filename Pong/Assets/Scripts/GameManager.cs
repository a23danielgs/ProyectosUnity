using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool running = false;
    int p1Score;
    int p2Score;
    [SerializeField] TMP_Text txtP1Score;
    [SerializeField] TMP_Text txtP2Score;
    [SerializeField] GameObject pelota; 
    
    public void AddPointP1() { 
        p1Score++; 
        txtP1Score.text = p1Score.ToString();
    }
    public void AddPointP2() {
        p2Score++; 
        txtP2Score.text = p2Score.ToString();
    }
    void Start()
    {
        Cursor.visible = false;
    }
    void Update(){
        if(!running && Input.GetKeyDown(KeyCode.Space)){
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
}
