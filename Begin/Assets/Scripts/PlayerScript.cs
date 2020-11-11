using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{

	public Text scoreText; // Текстовая переменная
	private int score; // Значение текстовой переменной
	Vector3 L; // Координаты левой стороны
	Vector3 R;// Координаты правой стороны
	public GameObject Ninja; // Присвоение Ниндзя в инспекторе MainCamera
	public Text CoinsText;
	public int Coins;
	public int CoinsLevel;
	public int CoinsLevelPrint;
	
	public GameObject loh;
	public Button Clicker;
	public Button Repeat;
	public Button Continue;
	public Button MoneyBtn;

	/*ublic float Distance = 0;
	public Text DistanceText;

	public static float speed = 0.03f;
	public static float timer = 100f;
	public static float step = 0.01f;

	float PrintSpeed;*/
	

	private void Start()
    {
		
        if (!PlayerPrefs.HasKey("AllMoney"))
        {
			PlayerPrefs.SetInt("AllMoney", 0);
        }
		Coins = PlayerPrefs.GetInt("AllMoney");
		CoinsLevel = 0;
		CoinsLevelPrint = 0;
		CoinsText.text = CoinsLevel + "";

	}

	void FixedUpdate()
    {
			/*timer -= Time.deltaTime;
			if (timer <= 0)
			{
				speed = speed + step;
				timer = 100f;
			}


			PrintSpeed = speed*10;
			Distance = PrintSpeed * Time.time;
			DistanceText.text = "Distance:" + Distance;	*/		
	}

	public void OnClick()  //При тапе
	{

		score++;  // Увеличивать значение текстовой переменной на 1 при каждом нажатии
		scoreText.text = score + ""; //Вывод на экран значения текстовой переменной
		L = new Vector3(1.37402f, -3.10165f, 0); //Левая сторона по X=1 по Y=-3 по Z=0
		R = new Vector3(-1.37402f, -3.10165f, 0); //Правая сторона по X=-1 по Y=-3 по Z=0

		if (Ninja.transform.position == L) //Если Ниндзя находится слева, то
		{
			Ninja.transform.position = R; //Переместить его в право 
			Ninja.transform.rotation = Quaternion.Euler(0, 0, -90); // Повернуть в противоположную сторону 
			Ninja.transform.localScale = new Vector3(-0, 0, 0); // Изменить его ориентацию
		
		}
		else //Иначе
		{
			Ninja.transform.position = L; //Переместить его в лево
			Ninja.transform.rotation = Quaternion.Euler(0, 0, 90); // Повернуть в противоположную сторону 
			Ninja.transform.localScale = new Vector3(0, 0, 0); // Изменить его ориентацию
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
        {
			
			CoinsLevel=1;
			CoinsLevelPrint++;
			Coins = Coins + CoinsLevel; 
			CoinsText.text = CoinsLevelPrint + "";
			PlayerPrefs.SetInt("AllMoney", Coins);
			PlayerPrefs.SetInt("CoinLevel", CoinsLevelPrint);
			Destroy(other.gameObject);
			
        }

        if (other.gameObject.tag == "Finish")
		{
			loh.SetActive(true);
			Clicker.gameObject.SetActive(false);
			Time.timeScale = 0f;
			
		}
			
	}
	
	public void Continued()
	{
		loh.SetActive(false);
		Clicker.gameObject.SetActive(true);
		Time.timeScale = 1f;
		
	}

	public void Money()
    {
		PlayerPrefs.HasKey("CoinLevel");
		CoinsLevelPrint= PlayerPrefs.GetInt("CoinLevel");
		Coins = Coins + CoinsLevelPrint;
		PlayerPrefs.SetInt("AllMoney", Coins);
		MoneyBtn.gameObject.SetActive(false);

	}


}
