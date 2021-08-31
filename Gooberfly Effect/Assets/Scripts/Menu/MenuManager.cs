using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class MenuManager : MonoBehaviour
{
    public bool menuOpen = false;
    public GameObject UI, shooting, menu, credits;
    public Animator anim;
    public bool tutorial;
    public static bool tutorial2 = true;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOpen)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Time.timeScale = 1;
                UI.SetActive(false);
                menuOpen = false;
                shooting.SetActive(true);
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
                UI.SetActive(true);
                menuOpen = true;
                shooting.SetActive(false);
            }
        }

        if (Chaos.tutDone && tutorial2)
        {
            SceneManager.LoadScene(2);
            tutorial2 = false;
        }

        if (PlayerHealth.health <= 0)
        {
            SceneManager.LoadScene(2);
            Chaos.chaosLevel = 0;
        }
    }

    public void Continue()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        UI.SetActive(false);
        menuOpen = false;
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void CreditsEnter()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }
    public void CreditsExit()
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
