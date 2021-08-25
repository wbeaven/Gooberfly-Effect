using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public bool menuOpen = false;
    public GameObject UI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOpen)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                UI.SetActive(false);
                menuOpen = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                UI.SetActive(true);
                menuOpen = true;
            }
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("William City");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
