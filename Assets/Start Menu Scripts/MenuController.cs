using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private const string CLASSIC_SCENE_NAME = "Classic";

    public void LoadClassic()
    {
        SceneManager.LoadScene(CLASSIC_SCENE_NAME);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
