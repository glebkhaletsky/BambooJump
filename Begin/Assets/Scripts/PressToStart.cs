using UnityEngine;
using UnityEngine.UI;

public class PressToStart : MonoBehaviour
{
    public bool Active;
    public Button StartBtn;

     void Start()
    {
        Active=GetComponent<RunShur>().Ebala; 
    }
    public void Press()
    {
        //Active = false;
        StartBtn.gameObject.SetActive(false);

    }
}
