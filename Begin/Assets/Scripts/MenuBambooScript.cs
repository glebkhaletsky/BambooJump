using UnityEngine;

public class MenuBambooScript : MonoBehaviour
{
    public GameObject FrontBamboo;
    public GameObject FrontBamboo1;
    public GameObject FrontBamboo2;
    public GameObject FrontBamboo3;

    public GameObject SecondBamboo;
    public GameObject SecondBamboo1;
    public GameObject SecondBamboo2;
    public GameObject SecondBamboo3;

    public GameObject ThreeBamboo;
    public GameObject ThreeBamboo1;
    public GameObject ThreeBamboo2;
    public GameObject ThreeBamboo3;

    public GameObject ground;
    public GameObject ground1;
    public GameObject ground2;
    public GameObject ground3;


    // Update is called once per frame
    void Update()
    {
        if (FrontBamboo.transform.position.x < -5.58)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            FrontBamboo.transform.position = new Vector3(15.65f, 2.93f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (FrontBamboo1.transform.position.x < -5.58)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            FrontBamboo1.transform.position = new Vector3(15.65f, 2.93f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (FrontBamboo2.transform.position.x < -5.58)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            FrontBamboo2.transform.position = new Vector3(15.65f, 2.93f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (FrontBamboo3.transform.position.x < -5.58)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            FrontBamboo3.transform.position = new Vector3(15.65f, 2.93f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }

        if (SecondBamboo.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            SecondBamboo.transform.position = new Vector3(16.99f, 2.58f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (SecondBamboo1.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            SecondBamboo1.transform.position = new Vector3(16.99f, 2.58f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (SecondBamboo2.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            SecondBamboo2.transform.position = new Vector3(16.99f, 2.58f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (SecondBamboo3.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            SecondBamboo3.transform.position = new Vector3(16.99f, 2.58f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }

        if (ThreeBamboo.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ThreeBamboo.transform.position = new Vector3(16.79f, 1.5f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (ThreeBamboo1.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ThreeBamboo1.transform.position = new Vector3(16.79f, 1.5f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (ThreeBamboo2.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ThreeBamboo2.transform.position = new Vector3(16.79f, 1.5f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (ThreeBamboo3.transform.position.x < -5.35f)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ThreeBamboo3.transform.position = new Vector3(16.79f, 1.5f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }


        if (ground.transform.position.x < -6.68)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ground.transform.position = new Vector3(19.82f, -4.18f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
        if (ground1.transform.position.x < -6.68)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ground1.transform.position = new Vector3(19.82f, -4.18f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }

        if (ground2.transform.position.x < -6.68)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ground2.transform.position = new Vector3(19.82f, -4.18f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }

        if (ground3.transform.position.x < -6.68)  //если блок бамбука достиг точки по оси Y -7,96            
        {
            ground3.transform.position = new Vector3(19.82f, -4.18f, 0); //то перебросить блок бамбука на точку по оси Y 9.88
        }
    }
}
