using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMenager : MonoBehaviour
{
    public void changeScen()
    {
        SceneManager.LoadScene(1);
    }

    public void goBack()
    {
        SceneManager.LoadScene(2);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("QUit Game");
    }

    public void getSettings()
    {
        Debug.Log("Get Settings");
    }

    public void goMathLab()
    {
        SceneManager.LoadScene(3);
    }
    public void goTeaTime()
    {
        SceneManager.LoadScene(5);
    }
}
