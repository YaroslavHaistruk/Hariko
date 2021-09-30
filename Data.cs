using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
	public static int Zloto;
	public static int Almaz;
	
	public Text TextZloto;
	public Text TextAlmaz;
	
	public int PrizeZloto;
	public int PrizeAlmaz;
	
	public GameObject l2;
    public GameObject l3;
	public GameObject l4;
    public GameObject l5;
	int sl2 = 2;
	int sl3 = 3;
	int sl4 = 4;
	int sl5 = 5;
	
	public int scenN;
	void Start()
	{
		scenN = PlayerPrefs.GetInt("scenes",1);
		if(scenN < sl2)
		{
			l2.SetActive(false);
			l3.SetActive(false);
			l4.SetActive(false);
			l5.SetActive(false);
		}
		if(scenN == sl2)
		{
			l2.SetActive(true);
		}
		else if(scenN == sl3)
		{
			l2.SetActive(true);
			l3.SetActive(true);
		}
		else if(scenN == sl4)
		{
			l2.SetActive(true);
			l3.SetActive(true);
			l4.SetActive(true);
		}
		else if(scenN >= sl5)
		{
			l2.SetActive(true);
			l3.SetActive(true);
			l4.SetActive(true);
			l5.SetActive(true);
		}
	}
	void Update()
	{
		TextAlmaz.text = Almaz.ToString();
		TextZloto.text = Zloto.ToString();
	}
	
	public void PlusZ()
	{
		Zloto ++;
	}
	public void PlusA()
	{
		Almaz ++;
	}
	public void finlvl()
	{
		Zloto +=PrizeZloto;
		Almaz +=PrizeAlmaz;
	}
	public void TradeItem1()
	{
		if(Almaz >= 1)
        {
            Zloto += 10;
			Almaz -=1;
			Save.SaveD();
        }
	}
	public void TradeItem2()
	{
		if(Almaz >= 5)
        {
            Zloto += 55;
			Almaz -=5;
            Save.SaveD();
        }
	}
	public void TradeItem3()
	{
		if(Almaz >= 10)
        {
            Zloto += 120;
			Almaz -=10;
            Save.SaveD();
        }
	}
	public void TradeItem4()
	{
		if(Zloto >= 15)
        {
            Zloto -= 15;
			Almaz +=1;
            Save.SaveD();
        }
	}
}
