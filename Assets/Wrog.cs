using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrog : MonoBehaviour
{
    Rigidbody2D r;
	public GameObject Player;
	
	public Transform PosPlayer;
	
	public GameObject pula;
	public Transform Firezone;
	public GameObject bron;
	
	private GameObject  sceman;
	
	float wrogspeed= 1;
    bool otw;
	
	public Transform Patzone;
	public int Patzo;
	public float rasto;
	public int reload = 0;
	private int reloadMax = 200;
	
	bool A = false;
	bool P = false;
	bool N = false;
	
    void Start()
    {
        r = GetComponent<Rigidbody2D> ();
        
    }

    void Update()
    {
		if (reload >= 1)
		{
			reload--;
		}
		if(Vector2.Distance(transform.position, Patzone.position) < Patzo && A == false)
		{
			P = true;
		}
		if(Vector2.Distance(transform.position, PosPlayer.position) < rasto)
		{
			A = true;
			P = false;
			N = false;
		}
		if(Vector2.Distance(transform.position, PosPlayer.position) > rasto)
		{
			N = true;
			A = false;
		}
		
		if(P == true)
		{
			Patrul();
		}
		else if (A == true)
		{
			GoAtak();
		} 
		else if(N == true)
		{
			Nazad();
		}
		
    }
	
	void GoAtak()
	{
		bron.SetActive(true);
		if(transform.position.x > PosPlayer.position.x)
		{
			otw = false;
			otherway();
		}
		else if (transform.position.x < PosPlayer.position.x)
		{
			otw = true;
			otherway();
		}
		
		transform.position = Vector2.MoveTowards(transform.position, PosPlayer.position, wrogspeed * Time.deltaTime);
		
		RaycastHit2D ray = Physics2D.Raycast(Firezone.position, Firezone.right);

		if (ray)
		{
			if (ray.transform.tag == "Player")
			{
				ataka();
			}
		}
	}
	void Patrul()
	{
		bron.SetActive(false);
		if(transform.position.x > Patzone.position.x + Patzo)
		{
			otw = false;
			otherway();
		}
		else if (transform.position.x < Patzone.position.x - Patzo)
		{
			otw = true;
			otherway();
		}
		
		if (otw)
		{
			transform.position = new Vector2(transform.position.x + wrogspeed * Time.deltaTime,transform.position.y);
		}
		else
		{
			transform.position = new Vector2(transform.position.x - wrogspeed * Time.deltaTime,transform.position.y);
		}
	}
	void Nazad()
	{
		bron.SetActive(false);
		transform.position = Vector2.MoveTowards(transform.position, Patzone.position, wrogspeed * Time.deltaTime);
	}
	void ataka()
	{
		if (reload <= 0)
		{
			Instantiate(pula, Firezone.position, Firezone.rotation);
			reload = reloadMax;
		}
	}
	void otherway()
    {
        if (otw == false)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
            
        if (otw == true)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}