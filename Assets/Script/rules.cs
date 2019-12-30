using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rules : MonoBehaviour
{
    public static bool gameispaused = false;

    public GameObject rulesUI;

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.W))
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
        rulesUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
    }
    void pause()
    {
        rulesUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }


    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}

