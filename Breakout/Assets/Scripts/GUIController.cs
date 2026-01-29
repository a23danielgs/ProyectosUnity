using UnityEngine;
using TMPro;

public class GUIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtlives; 

    // Referencia al texto para mostrar la puntuación en la interfaz
    [SerializeField] TextMeshProUGUI txtScore;
    private void OnGUI(){
        // Actualizamos el texto de la puntuación
        txtScore.text = string.Format("{0,2:D2}", GameManager.Score);  // Formateamos a 3 dígitos
        txtlives.text = GameManager.Lives.ToString();
    }
}
