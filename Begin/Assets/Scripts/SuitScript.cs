using UnityEngine;

public class SuitScript : MonoBehaviour
{
    public GameObject Standart;
    public GameObject Jora;
    public GameObject Camo;
    public GameObject Santa;
    public int SuitIndex;

    void Start()
    {
        PlayerPrefs.HasKey("Suit");
        SuitIndex = PlayerPrefs.GetInt("Suit");
        switch (SuitIndex)
        {
            case (0):
                Standart.SetActive(true);
                break;
            case (1):
                Camo.SetActive(true);
                break;
            case (2):
                Jora.SetActive(true);
                break;
            case (3):
                Santa.SetActive(true);
                break;

        }
    }
}
