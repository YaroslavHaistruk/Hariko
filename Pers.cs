using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pers : MonoBehaviour
{
    Rigidbody2D r;
    public int PersLife = 5;
	
    public GameObject buttonl;
    public GameObject buttonr;
	public GameObject buttonj;
    public GameObject buttona;
	
	public GameObject pula1;
	public GameObject pula2;
	public GameObject pula3;
	public GameObject pula4;
	
	public Transform Firezone;
	public GameObject panelDie;
	public GameObject PanelFinish;
	
	private GameObject  sceman;
	
	public float persspeed;
    bool otw;
	bool ml;
	bool mr;
	bool persground = false;
	
	
    void Start()
    {
        r = GetComponent<Rigidbody2D> ();
        ml = false;
		mr = false;
    }

    void Update()
    {
        if (PersLife <= 0)
        {
			panelDie.SetActive(true);
        }
		if (PersLife > 5)
        {
			PersLife = 5;
        }
		
		if(ml)
		{
			persspeed = -3f;
		}
		else if(mr)
		{
			persspeed = 3f;
		}
		else
		{
			persspeed = 0;
		}		
    }
	
	void FixedUpdate()
	{
		r.velocity = new Vector2 (persspeed, r.velocity.y);
	}
	
    public void Dlife(int damage) // Metod ktory minusuje punkt zycia;
	{
		PersLife -= damage;
	}
	
	public void persjump()
    {
		if (persground == true)
		{
			r.AddForce(transform.up * 6f, ForceMode2D.Impulse);
		}
    }
	void OnTriggerStay2D(Collider2D cl)
	{
		if (cl.tag == "ground") persground = true;
		if (cl.tag == "desplat") persground = true;
		if (cl.tag == "Lastground") persground = true;
		if (cl.gameObject.tag == "Lastground")
        {
            
			cl.gameObject.transform.position += new Vector3(0f, -1 * Time.deltaTime, 0f);
        }
	}
	void OnTriggerExit2D(Collider2D cl)
	{
		if (cl.tag == "ground") persground = false;
		if (cl.tag == "desplat") persground = false;
		if (cl.tag == "Lastground") persground = false;
	}
	
	public void ataka()
	{
		if(PlayerPrefs.GetInt("g1") == 1)
		{
			Instantiate(pula2, Firezone.position, Firezone.rotation);
		}
		else if(PlayerPrefs.GetInt("g2") == 2)
		{
			Instantiate(pula1, Firezone.position, Firezone.rotation);
		}
		else if(PlayerPrefs.GetInt("g3") == 3)
		{
			Instantiate(pula3, Firezone.position, Firezone.rotation);
		}
		else if(PlayerPrefs.GetInt("g4") == 4)
		{
			Instantiate(pula4, Firezone.position, Firezone.rotation);
		}
		else if(PlayerPrefs.GetInt("g5") == 5)
		{
			Instantiate(pula2, Firezone.position, Firezone.rotation);
		}
	}
	
	public void persrunleft()
	{
		ml = true;
		otw = true;
		otherway();
	}
	public void runleftoff()
	{
		ml = false;
	}
	public void persrunright()
	{
		mr = true;
		otw = false;
		otherway();
	}
	public void runrightoff()
	{
		mr = false;
	}
	public void LvlUp()
	{
		Data Zloto = GetComponent<Data>();
		if(Zloto)
		{
			Zloto.finlvl();
		}
	}
	
	
    void otherway()
    {
        if (otw == false)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
            
        if (otw == true)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D cl)
    {
        if (cl.gameObject.tag == "Enem")
        {
            PersLife--;
        }
		if (cl.gameObject.tag == "desplat")
        {
            Destroy (cl.gameObject,1);
        }
		if (cl.gameObject.tag == "diezone")
        {
            PersLife = 0;
        }
		if (cl.gameObject.tag == "Chmara")
        {
			r.AddForce (transform.up * 5, ForceMode2D.Impulse);
        }
    }
	
    void OnTriggerEnter2D(Collider2D cl)
    {
        if (cl.gameObject.tag == "pllife")
        {
            PersLife++;
            Destroy (cl.gameObject);
        }
		if (cl.gameObject.tag == "zloto")
		{
			Data Zloto = GetComponent<Data>();
			if(Zloto)
			{
				Zloto.PlusZ();
			}
		Destroy (cl.gameObject);
		}
			
		if (cl.gameObject.tag == "almaz")
		{
			Data Almaz = GetComponent<Data>();
			if(Almaz)
			{
				Almaz.PlusA();
			}
		Destroy (cl.gameObject);
		}
        if (cl.gameObject.tag == "finish")
        {
			PanelFinish.SetActive(true);
        }
    }
	
	
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
