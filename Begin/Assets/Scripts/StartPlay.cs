using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour
{
    public GameObject Pers;
    public GameObject Shadow;
    float x=0;

    public void Onclick()
    {
        x = 0.05f;
    }
    void FixedUpdate()
    {
        //GetComponent<RunShur>().enabled=true;
        Pers.transform.Translate(new Vector3(x, 0,0));
        Shadow.transform.Translate(new Vector3(x, 0, 0));
        if (Pers.transform.position.x >= 6)
        {
            Next(1);
        }
    }

    void Next(int _sceneNumber)
    {

        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}

