using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtransY : MonoBehaviour
{
	Rigidbody2D r;
	public float s;
	private float wt;
	public float swt;
	
	public Transform[] ms;
	private int rs;
	
    void Start()
    {
		wt = swt;
		rs = 0;
		
        r = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
		transform.position = Vector2.MoveTowards(transform.position, ms[rs].position, s * Time.deltaTime);
		if(Vector2.Distance(transform.position, ms[rs].position) < 0.2f)
		{
			if (wt <= 0)
			{
				rs = 1;
				wt = swt;
			}
			else
			{
				rs = 0;
				wt = -swt;
			}
		}
    }
	
}
