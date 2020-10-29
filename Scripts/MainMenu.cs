using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LevelSelect_2()
        {
            SceneManager.LoadScene("Level 2");
        }
    public void LevelSelect_3()
        {
            SceneManager.LoadScene("Level 3");
        }
    public void LevelSelect_4()
        {
            SceneManager.LoadScene("Level 4");
        }
    public void LevelSelect_5()
        {
            SceneManager.LoadScene("Level 5");
        }
    public void LevelSelect_6()
        {
            SceneManager.LoadScene("Level 6");
        }
    public void LevelSelect_7()
        {
            SceneManager.LoadScene("Level 7");
        }
    public void LevelSelect_8()
        {
            SceneManager.LoadScene("Level 8");
        }
    public void LevelSelect_9()
        {
            SceneManager.LoadScene("Level 9");
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
