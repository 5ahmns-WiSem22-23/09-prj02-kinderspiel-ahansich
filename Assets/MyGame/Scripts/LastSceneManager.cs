using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastSceneManager : MonoBehaviour
{
    public Text status;

    private void Start()
    {
        status.text = MainSceneManager.winner == MainSceneManager.Item.Boat ? "Das Boot ist der Sieger" : MainSceneManager.fishCount <= 2 ? "Unentschieden" : "Die Fische sind die Sieger";
    }

    public void PressRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
