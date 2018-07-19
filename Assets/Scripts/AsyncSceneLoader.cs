using UnityEngine;
using System.Collections;

public class AsyncSceneLoader : MonoBehaviour
{

    public float loadingDelay = 5.0F;

    void Start() {

        // Delay is important to ensure the APIs and files are loaded.
        StartCoroutine(LoadNextSceneAfter(loadingDelay));

    }

    private IEnumerator LoadNextSceneAfter(float seconds) {

        yield return new WaitForSeconds(seconds);

        // This method ensures the AR scene will be loaded afetr the splash screen.
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);

    }

}
