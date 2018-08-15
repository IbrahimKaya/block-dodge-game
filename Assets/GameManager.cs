using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float slowTime = 10f;

	public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale =1f/ slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowTime;

        yield return new WaitForSeconds(1f / slowTime);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowTime;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
