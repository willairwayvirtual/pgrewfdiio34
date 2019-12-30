using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause2 : MonoBehaviour
{
    public static bool gameispaused = false;

    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                if (gameispaused)

                {
                    Resume();
                }
                else
                {
                    pause();
                }
        }
    }
    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }


    public void restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void menu1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void all_levels1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
    public void menu2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    public void all_levels2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
    public void menu3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }

    public void all_levels3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
    }
    public void menu4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }

    public void all_levels4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -5);
    }
    public void menu5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }

    public void all_levels5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -6);
    }
    public void menu6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void all_levels6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -7);
    }
    public void menu7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void all_levels7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
    public void menu8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }

    public void all_levels8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }
    public void menu9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 12);
    }
    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
}