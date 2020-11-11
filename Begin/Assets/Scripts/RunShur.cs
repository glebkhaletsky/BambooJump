using UnityEngine;
public class RunShur : MonoBehaviour 
{
    static float speed = 0.03f;
    static float timer = 10f;
    static float step = 0.01f;
    public bool Ebala;
    public bool Kastil;
       

    void Start()
    {
        Ebala = false;
    }
   public void Go()
    {
        Ebala = true;
    }
    void FixedUpdate()
    {

        if (Ebala == true)
        {
            speed = 0.03f;
            timer = 10f;
            step = 0.01f;
        }
        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            speed = speed + step;
            timer = 10f;
            
        }
    
        

            transform.Translate(new Vector3(0, -speed, 0)); // движение всех сюрикенов по оси Y со скоростью -0,2 

           
        if (transform.position.y < -10) // если сюрикен опустился ниже -7 по оси Y, то...
            {
                Destroy(gameObject, 1); // ему пизда ^_^
            }


    }
    
}