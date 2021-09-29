using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemObj : MonoBehaviour
{
    Rigidbody2D r;
	public float s;
	private float wt;
	public float swt;
	
	public Transform[] ms;
	private int rs;
	public bool b;
	
	
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
				b = true;
			}
			else
			{
				rs = 0;
				wt = -swt;
				b = false;
			}
		}
		if (b == true)
			{
				transform.Rotate(new Vector3(0, 0, -50) * Time.deltaTime);
			}
			if (b == false)
			{
				transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
			}
    }
	
}
