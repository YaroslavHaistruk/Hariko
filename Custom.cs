using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom : MonoBehaviour
{
    public GameObject pers2;
    public GameObject pers3;
	public GameObject pers4;
	
    public GameObject szapa1;
	public GameObject szapa2;
	public GameObject szapa3;
	public GameObject szapa4;
	
	public GameObject gun1;
	public GameObject gun2;
	public GameObject gun3;
	public GameObject gun4;
	
	int p1;
	int p2;
	int p3;
	int p4;
	
	int s1;
	int s2;
	int s3;
	int s4;
	int s5;
	
	int g1;
	int g2;
	int g3;
	int g4;
	int g5;
	
	void Start()
	{
		p1 = PlayerPrefs.GetInt("p1", 1);
		p2 = PlayerPrefs.GetInt("p2", 1);
		p3 = PlayerPrefs.GetInt("p3", 1);
		p4 = PlayerPrefs.GetInt("p4", 1);
		
		s1 = PlayerPrefs.GetInt("s1", 1);
		s2 = PlayerPrefs.GetInt("s2", 1);
		s3 = PlayerPrefs.GetInt("s3", 1);
		s4 = PlayerPrefs.GetInt("s4", 1);
		s5 = PlayerPrefs.GetInt("s5", 1);
		
		g1 = PlayerPrefs.GetInt("g1", 1);
		g2 = PlayerPrefs.GetInt("g2", 1);
		g3 = PlayerPrefs.GetInt("g3", 1);
		g4 = PlayerPrefs.GetInt("g4", 1);
		g5 = PlayerPrefs.GetInt("g5", 1);
	}
	void Update()
	{
		if(p1 == 1)
        {
            
            pers2.SetActive(false);
			pers3.SetActive(false);
			pers4.SetActive(false);
        } 
		

        if (p2 == 2)
        {
            pers2.SetActive(true);
			pers3.SetActive(false);
			pers4.SetActive(false);
        } else
        {
            pers2.SetActive(false);
        }
		
		if (p3 == 3)
        {
            pers2.SetActive(false);
			pers3.SetActive(true);
			pers4.SetActive(false);
        } else
        {
            pers3.SetActive(false);
        }
		
		if (p4 == 4)
        {
            pers2.SetActive(false);
			pers3.SetActive(false);
			pers4.SetActive(true);
        } else
        {
            pers4.SetActive(false);
        }
		
		//Sprawdzanie Szap ==========================================================
		
		if(s2 == 2)
        {
            szapa1.SetActive(true);
            szapa2.SetActive(false);
			szapa3.SetActive(false);
			szapa4.SetActive(false);
        } 
		else
		{
			szapa1.SetActive(false);
		}

        if (s3 == 3)
        {
            szapa1.SetActive(false);
            szapa2.SetActive(true);
			szapa3.SetActive(false);
			szapa4.SetActive(false);
        } else
        {
            szapa2.SetActive(false);
        }
		
		if (s4 == 4)
        {
            szapa1.SetActive(false);
            szapa2.SetActive(false);
			szapa3.SetActive(true);
			szapa4.SetActive(false);
        } else
        {
            szapa3.SetActive(false);
        }
		
		if (s5 == 5)
        {
            szapa1.SetActive(false);
            szapa2.SetActive(false);
			szapa3.SetActive(false);
			szapa4.SetActive(true);
        } else
        {
            szapa4.SetActive(false);
        }
		if (s1 == 1)
        {
            szapa1.SetActive(false);
            szapa2.SetActive(false);
			szapa3.SetActive(false);
			szapa4.SetActive(false);
        }
		
		//Sprawdzanie Broni ==========================================================
		
		if(g2 == 2)
        {
            gun1.SetActive(true);
            gun2.SetActive(false);
			gun3.SetActive(false);
			gun4.SetActive(false);
        } 
		else
		{
			gun1.SetActive(false);
		}

        if (g3 == 3)
        {
            gun1.SetActive(false);
            gun2.SetActive(true);
			gun3.SetActive(false);
			gun4.SetActive(false);
        } else
        {
            gun2.SetActive(false);
        }
		
		if (g4 == 4)
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
			gun3.SetActive(true);
			gun4.SetActive(false);
        } else
        {
            gun3.SetActive(false);
        }
		
		if (g5 == 5)
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
			gun3.SetActive(false);
			gun4.SetActive(true);
        } else
        {
            gun4.SetActive(false);
        }
		if (g1 == 1)
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
			gun3.SetActive(false);
			gun4.SetActive(false);
        }
	}
	
	public void WyborP1()
	{
		p1 = 1;
		PlayerPrefs.SetInt("p1", p1);
		p2 = 1;
		PlayerPrefs.SetInt("p2", p2);
		p3 = 1;
		PlayerPrefs.SetInt("p3", p3);
		p4 = 1;
		PlayerPrefs.SetInt("p4", p4);
	}
		
	public void WyborP2()
	{
		p1 = 2;
		PlayerPrefs.SetInt("p1", p1);
		p2 = 2;
		PlayerPrefs.SetInt("p2", p2);
		p3 = 2;
		PlayerPrefs.SetInt("p3", p3);
		p4 = 2;
		PlayerPrefs.SetInt("p4", p4);
	}
	public void WyborP3()
	{
		p1 = 3;
		PlayerPrefs.SetInt("p1", p1);
		p2 = 3;
		PlayerPrefs.SetInt("p2", p2);
		p3 = 3;
		PlayerPrefs.SetInt("p3", p3);
		p4 = 3;
		PlayerPrefs.SetInt("p4", p4);
	}
	public void WyborP4()
	{
		p1 = 4;
		PlayerPrefs.SetInt("p1", p1);
		p2 = 4;
		PlayerPrefs.SetInt("p2", p2);
		p3 = 4;
		PlayerPrefs.SetInt("p3", p3);
		p4 = 4;
		PlayerPrefs.SetInt("p4", p4);
	}
	// Zmiana Szap ==========================================
	public void WyborS1()
	{
		s1 = 1;
		PlayerPrefs.SetInt("s1", s1);
		s2 = 1;
		PlayerPrefs.SetInt("s2", s2);
		s3 = 1;
		PlayerPrefs.SetInt("s3", s3);
		s4 = 1;
		PlayerPrefs.SetInt("s4", s4);
		s5 = 1;
		PlayerPrefs.SetInt("s5", s5);
	}
		
	public void WyborS2()
	{
		s1 = 2;
		PlayerPrefs.SetInt("s1", s1);
		s2 = 2;
		PlayerPrefs.SetInt("s2", s2);
		s3 = 2;
		PlayerPrefs.SetInt("s3", s3);
		s4 = 2;
		PlayerPrefs.SetInt("s4", s4);
		s5 = 2;
		PlayerPrefs.SetInt("s5", s5);
	}
	public void WyborS3()
	{
		s1 = 3;
		PlayerPrefs.SetInt("s1", s1);
		s2 = 3;
		PlayerPrefs.SetInt("s2", s2);
		s3 = 3;
		PlayerPrefs.SetInt("s3", s3);
		s4 = 3;
		PlayerPrefs.SetInt("s4", s4);
		s5 = 3;
		PlayerPrefs.SetInt("s5", s5);
	}
	public void WyborS4()
	{
		s1 = 4;
		PlayerPrefs.SetInt("s1", s1);
		s2 = 4;
		PlayerPrefs.SetInt("s2", s2);
		s3 = 4;
		PlayerPrefs.SetInt("s3", s3);
		s4 = 4;
		PlayerPrefs.SetInt("s4", s4);
		s5 = 4;
		PlayerPrefs.SetInt("s5", s5);
	}
	public void WyborS5()
	{
		s1 = 5;
		PlayerPrefs.SetInt("s1", s1);
		s2 = 5;
		PlayerPrefs.SetInt("s2", s2);
		s3 = 5;
		PlayerPrefs.SetInt("s3", s3);
		s4 = 5;
		PlayerPrefs.SetInt("s4", s4);
		s5 = 5;
		PlayerPrefs.SetInt("s5", s5);
	}
	
	
	//Zmiana broni ===================================
	
	public void WyborG1()
	{
		g1 = 1;
		PlayerPrefs.SetInt("g1", g1);
		g2 = 1;
		PlayerPrefs.SetInt("g2", g2);
		g3 = 1;
		PlayerPrefs.SetInt("g3", g3);
		g4 = 1;
		PlayerPrefs.SetInt("g4", g4);
		g5 = 1;
		PlayerPrefs.SetInt("g5", g5);
	}
		
	public void WyborG2()
	{
		g1 = 2;
		PlayerPrefs.SetInt("g1", g1);
		g2 = 2;
		PlayerPrefs.SetInt("g2", g2);
		g3 = 2;
		PlayerPrefs.SetInt("g3", g3);
		g4 = 2;
		PlayerPrefs.SetInt("g4", g4);
		g5 = 2;
		PlayerPrefs.SetInt("g5", g5);
	}
	public void WyborG3()
	{
		g1 = 3;
		PlayerPrefs.SetInt("g1", g1);
		g2 = 3;
		PlayerPrefs.SetInt("g2", g2);
		g3 = 3;
		PlayerPrefs.SetInt("g3", g3);
		g4 = 3;
		PlayerPrefs.SetInt("g4", g4);
		g5 = 3;
		PlayerPrefs.SetInt("g5", g5);
	}
	public void WyborG4()
	{
		g1 = 4;
		PlayerPrefs.SetInt("g1", g1);
		g2 = 4;
		PlayerPrefs.SetInt("g2", g2);
		g3 = 4;
		PlayerPrefs.SetInt("g3", g3);
		g4 = 4;
		PlayerPrefs.SetInt("g4", g4);
		g5 = 4;
		PlayerPrefs.SetInt("g5", g5);
	}
	public void WyborG5()
	{
		g1 = 5;
		PlayerPrefs.SetInt("g1", g1);
		g2 = 5;
		PlayerPrefs.SetInt("g2", g2);
		g3 = 5;
		PlayerPrefs.SetInt("g3", g3);
		g4 = 5;
		PlayerPrefs.SetInt("g4", g4);
		g5 = 5;
		PlayerPrefs.SetInt("g5", g5);
	}
}
