using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private GameObject playMenu;
    private GameObject levelMenu;
    // Start is called before the first frame update
    void Start()
    {
        playMenu = GameObject.Find("Play Screen");
        levelMenu = GameObject.Find("Level Selection Screen");
        levelMenu.SetActive(false);
    }

    public void Play()
    {
        playMenu.SetActive(false);
        levelMenu.SetActive(true);
    }

    public void GoBack()
    {
        levelMenu.SetActive(false);
        playMenu.SetActive(true);
    }

    public void LoadLevel(int levelNum)
    {
            SceneManager.LoadScene(levelNum);
    }

}
