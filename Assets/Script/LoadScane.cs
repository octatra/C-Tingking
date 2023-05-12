using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScane : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("CtLevel1");
    }
    public void level2()
    {
        SceneManager.LoadScene("CtLevel2");
    }
    public void level3()
    {
        SceneManager.LoadScene("CtLevel3");
    }

    public void S2L1()
    {
        SceneManager.LoadScene("Stage2L1");
    }
    public void S2L2()
    {
        SceneManager.LoadScene("Stage2L2");
    }
    public void S2L3()
    {
        SceneManager.LoadScene("Stage2L3");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void SoalS1L1()
    {
        SceneManager.LoadScene("SoalS1L2" +
            "");
    }
    public void SoalS2L1()
    {
        SceneManager.LoadScene("SoalS2L2");
    }
}
