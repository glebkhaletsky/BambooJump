using System.Collections;
using UnityEngine;

public class SpawnCloudScript : MonoBehaviour
{
    GameObject CLoud;
    public GameObject CLoud1;
    public GameObject CLoud2;
    public GameObject CLoud3;
    public GameObject SpawnPos;
    public int rnd;

    void Start()
    {
        StartCoroutine(SpawnCloud()); // Запуск процесса создание сюрикена
    }


    void Repet() //функция повтора
    {

        StartCoroutine(SpawnCloud());// Запуск процесса создание сюрикена    

    }

    IEnumerator SpawnCloud()
    {
        rnd = Random.Range(1, 4);
        if (rnd == 1)
        {
            CLoud = CLoud1;
        }
        if (rnd == 2)
        {
            CLoud = CLoud2;
        }
        if (rnd == 3)
        {
            CLoud = CLoud3;
        }
        yield return new WaitForSeconds(10); //спаунить сюрикен каждые random секунды
        Instantiate(CLoud, SpawnPos.transform.position, Quaternion.identity); //1-что именно спаунить, 2-его позиция, 3-вращение
        Repet();
    }
}
