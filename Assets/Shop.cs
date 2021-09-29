using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ButtonBuy1;
	public GameObject ButtonBuy2;
	public GameObject ButtonBuy3;
	
	public GameObject Use1;
	public GameObject Use2;
	public GameObject Use3;
	
	public GameObject Bh1;
	public GameObject Bh2;
	public GameObject Bh3;
	public GameObject Bh4;
	
	public GameObject sh1;
	public GameObject sh2;
	public GameObject sh3;
	public GameObject sh4;
	
	public GameObject Bw1;
	public GameObject Bw2;
	public GameObject Bw3;
	public GameObject Bw4;
	
	public GameObject sw1;
	public GameObject sw2;
	public GameObject sw3;
	public GameObject sw4;
    
    void Update()
    {
        if (PlayerPrefs.GetInt("b1") == 1)
        {
            ButtonBuy1.SetActive(false);
			Use1.SetActive(true);
        }
        
		if (PlayerPrefs.GetInt("b2") == 1)
        {
            ButtonBuy2.SetActive(false);
			Use2.SetActive(true);
        }
        
		if (PlayerPrefs.GetInt("b3") == 1)
        {
            ButtonBuy3.SetActive(false);
			Use3.SetActive(true);
        }
		
		
		if (PlayerPrefs.GetInt("bh1") == 1)
        {
            Bh1.SetActive(false);
			sh1.SetActive(true);
        }
		if (PlayerPrefs.GetInt("bh2") == 1)
        {
            Bh2.SetActive(false);
			sh2.SetActive(true);
        }
		if (PlayerPrefs.GetInt("bh3") == 1)
        {
            Bh3.SetActive(false);
			sh3.SetActive(true);
        }
		if (PlayerPrefs.GetInt("bh4") == 1)
        {
            Bh4.SetActive(false);
			sh4.SetActive(true);
        }
		
		if (PlayerPrefs.GetInt("bw1") == 1)
        {
            Bw1.SetActive(false);
			sw1.SetActive(true);
        }
		if (PlayerPrefs.GetInt("bw2") == 1)
        {
            Bw2.SetActive(false);
			sw2.SetActive(true);
        }
		if (PlayerPrefs.GetInt("bw3") == 1)
        {
            Bw3.SetActive(false);
			sw3.SetActive(true);
        }
		if (PlayerPrefs.GetInt("bw4") == 1)
        {
            Bw4.SetActive(false);
			sw4.SetActive(true);
        }
    }
	
	public void Buy1()
	{
		if(Data.Zloto >= 20)
        {
            Data.Zloto -= 20;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("b1", 1);
        }
	}
	public void Buy2()
	{
		if(Data.Zloto >= 25)
        {
            Data.Zloto -= 25;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("b2", 1);
        }
	}
	public void Buy3()
	{
		if(Data.Zloto >= 25)
        {
            Data.Zloto -= 25;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("b3", 1);
        }
	}
	
	
	public void BuyHat1()
	{
		if(Data.Zloto >= 30)
        {
            Data.Zloto -= 30;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bh1", 1);
        }
	}
	
	public void BuyHat2()
	{
		if(Data.Zloto >= 40)
        {
            Data.Zloto -= 40;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bh2", 1);
        }
	}
	
	public void BuyHat3()
	{
		if(Data.Zloto >= 50)
        {
            Data.Zloto -= 50;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bh3", 1);
        }
	}
	
	public void BuyHat4()
	{
		if(Data.Zloto >= 60)
        {
            Data.Zloto -= 60;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bh4", 1);
        }
	}
	
	public void BuyWeapon1()
	{
		if(Data.Zloto >= 50)
        {
            Data.Zloto -= 50;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bw1", 1);
        }
	}
	public void BuyWeapon2()
	{
		if(Data.Zloto >= 70)
        {
            Data.Zloto -= 70;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bw2", 1);
        }
	}
	public void BuyWeapon3()
	{
		if(Data.Zloto >= 65)
        {
            Data.Zloto -= 65;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bw3", 1);
        }
	}
	public void BuyWeapon4()
	{
		if(Data.Zloto >= 35)
        {
            Data.Zloto -= 35;
            PlayerPrefs.SetInt("money", Data.Zloto);
            PlayerPrefs.SetInt("bw4", 1);
        }
	}
}
