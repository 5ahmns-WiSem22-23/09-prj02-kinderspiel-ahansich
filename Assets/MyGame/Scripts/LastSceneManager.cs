using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastSceneManager : MonoBehaviour
{
    public Text status;

    private void Start()
    {
        status.text = MainSceneManager.winner == "Boat" ? "Das Boot ist der Sieger" : "Die FIsche sind die Sieger";
    }

    public void PressRestart()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
