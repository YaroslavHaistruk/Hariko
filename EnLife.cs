using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnLife : MonoBehaviour
{
    public int life = 5;
	public int maxlife = 5;

	void Update()
	{

		if (life > maxlife)
		{
			life = maxlife;
		}

		if (life <= 0)
		{
			Endelet();
		}
	}

	public void Dlife(int damage) // Metod ktory minusuje punkt zycia;
	{
		life -= damage;
	}

	void Endelet()
	{
		Destroy(gameObject);
	}
}
