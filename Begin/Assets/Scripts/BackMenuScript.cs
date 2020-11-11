using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenuScript : MonoBehaviour
{
    public void SceneRepeat()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }


}
