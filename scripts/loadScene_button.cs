using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingLevel : MonoBehaviour
{

    public void ChangementScene(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
