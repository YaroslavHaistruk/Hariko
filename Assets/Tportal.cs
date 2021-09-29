using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tportal : MonoBehaviour
{
	public Transform zmpoz;
	public GameObject pers;
	public int x;
	public int y;
	
	void OnCollisionEnter2D(Collision2D cl)
    {
		if (cl.gameObject.tag == "Player")
        {
			pers.transform.position = zmpoz.position + new Vector3(x,y);
        }
    }
}