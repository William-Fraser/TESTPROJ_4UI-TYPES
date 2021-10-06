using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartorQuit : MonoBehaviour
{
    public void NewGame()
    {
        GameManager.manager.NewGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
