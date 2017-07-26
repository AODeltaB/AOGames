using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public GameObject LoadingScreen;
    public Slider slider;
    public Text progressText;
    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadAsynchronously(levelIndex));

    }
    IEnumerator LoadAsynchronously(int levelIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {

            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
