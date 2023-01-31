
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{

    public enum Item
    {
        Fish;
        Boat
    }

    public static Item currentWinner;

    public int moveAmount;

    public static int fishCount;

    public GameObject fishRed;
    public GameObject fishBlue;
    public GameObject fishGreen;
    public GameObject fishYellow;
    public GameObject boat;

    private void Start()
    {
        fishCount = 4;
    }

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
        item.transform.position = new Vector3(item.transform.position.x + moveAmount, item.transform.position.y, item.transform.position.z);
    }

    public void GameOver(Item winner)
    {
        currentWinner = winner;
        SceneManager.LoadScene("LastScene");
    }


    void RollDice()
    {
        int random = Random.Range(1, 7);

        switch (random)
            {
            case 1:
                // rot
                try
                {
                MoveItem(fishRed);
                }
                catch
                {
                    RollDice();
                }
                break;

            case 2:
                // grün
                try
                {
                MoveItem(fishGreen);
                }
                catch
                {
                    RollDice();
                }
                break;

            case 3:
                // blau
                try
                {
                MoveItem(fishBlue);
                }
                catch
                {
                    RollDice();
                }
                break;

            case 4:
                // gelb
                try
                {
                MoveItem(fishYellow);
                }
                catch
                {
                    RollDice();
                }
                break;

            case 5:
                // boot 1
                MoveItem(boat);
                break;

            case 6:
                // boot 2
                MoveItem(boat);
                break;
            }
    }

    public void CheckForWin()
    {
        fishCount--;

        if (fishCount <= 0)
        {
            GameOver(Item.Boat)
        }
    }


}
