using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Navigate : MonoBehaviour
{
    public Text DebagText; // Текстовая переменная
    //public Animator anim;
    
   /* void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Anim()
    {
        anim.Play("Start");
    }*/
    public void Next(int _sceneNumber)
    {
               
        SceneManager.LoadScene(_sceneNumber);
        Time.timeScale = 1f;
    }

}
