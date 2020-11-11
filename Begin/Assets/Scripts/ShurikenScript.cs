using System.Collections;
using UnityEngine;

public class ShurikenScript : MonoBehaviour

{
    public GameObject Shur; //Присвоение Сюрекена в инспекторе MainCamera, сам сюрекен в папке Prefabs
    public GameObject Shur2; //Присвоение Сюрекена в инспекторе MainCamera, сам сюрекен в папке Prefabs
    private GameObject Robj1; //Пустой рандомный объект 1
    private GameObject Robj2; //Пустой рандомный объект 2
    public GameObject Coin; //Присвоение Монетки в инспекторе MainCamera, сам сюрекен в папке Prefabs 
    public Transform SpawnPos; // Точка из которой происходит саун сюрекена
    public Transform SpawnPos2; // Точка из которой происходит саун сюрекена
    private float random; //создаём переменную, которая будет отвечать за рандомное появление сюрикенов
    private float random2;//создаём переменную, которая будет отвечать за рандомное появление сюрикенов
    public float min; //минимальное значение массива для рандомного сауна сюрекена
    public float max; //максимальное значение массива для рандомного сауна сюрекена
    public  float timer = 10f; //значение обратного отсчёта P.S. делать идентичным в BambooScript
    public  float step = 0.1f; // значение шага уменьшения времени респауна объектов
    public float rs; // определяет с какой стороны будет спауниться объект
    public float ro1; //определяет какой объект будет спауниться слева
    public float ro2; //определяет какой объект будет спауниться справа
       
    public void Start()
    {
        min = 0.6f; //минимальное време в секундах за которое спауниться объект
        max = min * 2; //максимальное време в секундах за которое спауниться объект
        StartCoroutine(SpawnCD()); // Запуск процесса создание сюрикена
    }

    void Repet() //функция повтора
    {

        StartCoroutine(SpawnCD());// Запуск процесса создание сюрикена    

    }
    
    
    IEnumerator SpawnCD() //спаун 
    {
        
             

            random = Random.Range(min, max); //присваиваем переменное рандомное значение за которое будет происходить спаун слева 
            random2 = Random.Range(min, max); //присваиваем переменное рандомное значение за которое будет происходить спаун спрва

            if (random2 == random) 
            {
                 random2 = random2 + min;
            }
            if ( random-random2 <= min)
             {
                 random2 = random2 + min;
            }
            if ( random - random2 >=-min)
            {
                random2 = random2 + min;
            }
            if (random2 - random <= min)
            {
                 random = random + min;
            }
            if (random2 - random >= -min)
            {
                 random = random + min;
            }

            rs = Random.Range(-1, 1);
            ro1 = Random.Range(-2, 2);
            ro2 = ro1;

            if (ro1 >= 1)
            {
                Robj1 = Coin;
            }
            else
            {
                Robj1 = Shur;
            }

            if (ro2 >= 1)
            {
                Robj2 = Coin;
            }
            else
            {
                Robj2 = Shur2;
            }


            if (rs >= 0)
            {
                yield return new WaitForSeconds(random); //спаунить сюрикен каждые random секунды
                Instantiate(Robj1, SpawnPos.position, Quaternion.identity); //1-что именно спаунить, 2-его позиция, 3-вращение
            }
            else
            {
            
                yield return new WaitForSeconds(random2); //спаунить сюрикен каждые random секунды
                Instantiate(Robj2, SpawnPos2.position, Quaternion.identity); //1-что именно спаунить, 2-его позиция, 3-вращение            
            }

            Repet();
        
    }
   
    void Update() 
    {
        

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            min = min - step;
            max = min * 2;
            timer = 10f;
        }

        if (min <= 0.2f)
        {
            step = 0.01f;
        }
    }


}
