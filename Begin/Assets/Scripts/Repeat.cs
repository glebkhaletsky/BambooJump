using UnityEngine;
using UnityEngine.SceneManagement;

public class Repeat : MonoBehaviour
{
    public bool RepeatBool;
  
    
    public void SceneRepeat()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

    }


}
