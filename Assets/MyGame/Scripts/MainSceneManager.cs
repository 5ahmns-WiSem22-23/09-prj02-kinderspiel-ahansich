
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    public static string winner;

    public GameObject fishRed;
    public GameObject fishBlue;
    public GameObject fishGreen;
    public GameObject fishYellow;
    public GameObject boat;

    int progressRed;
    int progressGreen;
    int progressBlue;
    int progressYellow;
    int progressBoat;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
            Debug.Log("hjkfb");
        }
    }

    void MoveItem(GameObject item)
    {
        item.transform.position = new Vector3(10, item.transform.position.y, item.transform.position.z);
    }

    void RollDice()
    {
        int random = Random.Range(1, 7);

        switch (random)
            {
            case 1:
                // rot
                MoveItem(fishRed);
                progressRed++;
                break;
            case 2:
                // grün
                MoveItem(fishGreen);
                progressGreen++;
                break;
            case 3:
                // blau
                MoveItem(fishBlue);
                progressBlue++;
                break;
            case 4:
                // gelb
                MoveItem(fishYellow);
                progressYellow++;
                break;
            case 5:
                // boot 1
                MoveItem(boat);
                progressBoat++;
                break;
            case 6:
                // boot 2
                MoveItem(boat);
                progressBoat++;
                break;
        }
    }
}
