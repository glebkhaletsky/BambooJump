using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public Text AllCoinsText;
    public int Coin;
   
   


    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (!PlayerPrefs.HasKey("AllMoney")){
            PlayerPrefs.SetInt("AllMoney", 0);
        }
        Coin = PlayerPrefs.GetInt("AllMoney");
        AllCoinsText.text = Coin + "";
    }

   


}
