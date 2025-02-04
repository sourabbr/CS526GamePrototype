using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    public void LoadLevel1()
    {
        gameManager.LoadSceneByName("Level1");
    }

    public void LoadLevel2()
    {
        gameManager.LoadSceneByName("Level2");
    }

    public void LoadLevel3()
    {
        gameManager.LoadSceneByName("Level3");
    }
}
