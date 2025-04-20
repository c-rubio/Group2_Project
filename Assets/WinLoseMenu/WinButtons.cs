using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButtons : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadSceneAsync(0); //0 is the index of Main Menu Screen
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnMaze() {
        SceneManager.LoadSceneAsync(1);
    }
}