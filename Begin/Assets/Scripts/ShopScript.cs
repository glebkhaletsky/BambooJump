using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    //public GameObject SuitStandart;
    public int SuitIndex=0;
    public Text CoinText;
    int Coin;
    public int StatusCamo=0;
    public int StatCamo=0;

    public int StatusJora = 0;
    public int StatJora = 0;

    public int StatusSanta = 0;
    public int StatSanta = 0;

    public GameObject ErrorPanel;

    public Button StandartButtonUse;

    public Button CamoButton;
    public Button CamoButtonUse;

    public Button JoraButton;
    public Button JoraButtonUse;

    public Button SantaButton;
    public Button SantaButtonUse;

    public Image Camo;




    void Start()
    {
        //PlayerPrefs.DeleteAll();

        //Получение данных об общем количетсве монет
        if (!PlayerPrefs.HasKey("AllMoney"))
        {
            PlayerPrefs.SetInt("AllMoney", 0);
        }
        Coin = PlayerPrefs.GetInt("AllMoney");
        CoinText.text = Coin + "";

        PlayerPrefs.HasKey("StatusCamo");
        StatCamo = PlayerPrefs.GetInt("StatusCamo");
        if (StatCamo == 1)
        {
            CamoButton.gameObject.SetActive(false);
            CamoButtonUse.gameObject.SetActive(true);
        }

        PlayerPrefs.HasKey("StatusJora");
        StatJora = PlayerPrefs.GetInt("StatusJora");
        if (StatJora == 1)
        {
            JoraButton.gameObject.SetActive(false);
            JoraButtonUse.gameObject.SetActive(true);
        }

        PlayerPrefs.HasKey("StatusSanta");
        StatSanta = PlayerPrefs.GetInt("StatusSanta");
        if (StatSanta == 1)
        {
            SantaButton.gameObject.SetActive(false);
            SantaButtonUse.gameObject.SetActive(true);
        }


    }
    
   public void BuySuitCamo()
    {
        if (Coin >= 10)
        {
            Coin = Coin - 10;
            PlayerPrefs.SetInt("AllMoney", Coin);
            StatusCamo = 1;
            PlayerPrefs.SetInt("StatusCamo", StatusCamo);
            Start();
        }
        else
        {
            ErrorPanel.SetActive(true);
        }
        

    }

    public void BuySuitJora()
    {
        if (Coin >= 10)
        {
            Coin = Coin - 10;
            PlayerPrefs.SetInt("AllMoney", Coin);
            StatusJora = 1;
            PlayerPrefs.SetInt("StatusJora", StatusJora);
            Start();
        }
        else
        {
            ErrorPanel.SetActive(true);
        }

    }
    public void BuySuitSanta()
    {
        if (Coin >= 10)
        {
            Coin = Coin - 10;
            PlayerPrefs.SetInt("AllMoney", Coin);
            StatusSanta = 1;
            PlayerPrefs.SetInt("StatusSanta", StatusSanta);
            Start();
        }
        else
        {
            ErrorPanel.SetActive(true);
        }

    }


    public void StandartActiveSuit()
    {
        SuitIndex = 0;
        PlayerPrefs.SetInt("Suit", SuitIndex);
    }

    public void CamoActiveSuit()
    {
        SuitIndex = 1;
        PlayerPrefs.SetInt("Suit", SuitIndex);
    }

    public void JoraActiveSuit()
    {
        SuitIndex = 2;
        PlayerPrefs.SetInt("Suit", SuitIndex);
    }

    public void SantaActiveSuit()
    {
        SuitIndex = 3;
        PlayerPrefs.SetInt("Suit", SuitIndex);
    }







    public void CloseError()
    {
        ErrorPanel.SetActive(false);
    }
}
