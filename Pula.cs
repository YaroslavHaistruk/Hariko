using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pula : MonoBehaviour
{
	Rigidbody2D r;
	private float psp = 20f; //Szybkosc
	private int life = 0;
	private int maxlife = 500;
	private int damage = 1;
	
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
		r.velocity = transform.right * psp; // Zmiana szybkosci
    }

    void Update()
    {
		life++;

		if (life >= maxlife)
		{
			Pdes(); // Usunienie puli jeśli nie trafiłeś w przedmiot
		}
    }
	void OnTriggerEnter2D(Collider2D c) //Metod jezeli trafiłeś
	{
		Pers PersLife = c.GetComponent<Pers>();
		if(PersLife)
		{
			PersLife.Dlife(damage);
		}
		
		
		EnLife life = c.GetComponent<EnLife>(); //sprawdza, czy trafiony obiekt ma life.Jeśli tak,to metoda Hit odbiera zdrowie.
		if (life)
		{
			life.Dlife(damage);
		}
		
		Pdes();
	}
	void Pdes()
	{
		Destroy(gameObject); //Usunienie puli
	}
}
