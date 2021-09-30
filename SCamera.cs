using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCamera : MonoBehaviour
{
	public Transform gcam;
	public float ymin;
	public float ymax;
	public float xmin;
	public float xmax;

    void Update()
    {
        UpdateCamPos();
    }
	void UpdateCamPos()
	{
		transform.position = new Vector3(
		Mathf.Clamp(gcam.position.x, xmin, xmax),
		Mathf.Clamp(gcam.position.y, ymin, ymax),
		transform.position.z);
	}
}
