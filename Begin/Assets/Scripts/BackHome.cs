using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackHome : MonoBehaviour
{
    
    public void Next(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
        Time.timeScale = 1f;
    }
}
