using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnNewGameClicked()
    {
        Debug.Log("Initializing New Game");
        DataPersistenceManager.instance.NewGame();
        SceneManager.LoadSceneAsync("Queue");
    }

    public void OnLoadGameClicked()
    {
        SceneManager.LoadSceneAsync("Queue");
    }
}
