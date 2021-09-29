using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeSlider : MonoBehaviour
{
	public Pers pers;
    public Image fillImage;
	private Slider sldr;
	
    void Awake()
	{
		sldr = GetComponent<Slider>();
	}

    
    void Update()
    {
		if(sldr.value <= sldr.minValue)
		{
			fillImage.enabled = false;
		}
		
		if(sldr.value > sldr.minValue && !fillImage.enabled)
		{
			fillImage.enabled = true;
		}
		
		float fValue = pers.PersLife;
		
		if(fValue == 2)
		{
			fillImage.color = Color.yellow;
		}
		else if(fValue > sldr.maxValue / 2)
		{
			fillImage.color = Color.green;
		}
		else if(fValue == 1)
		{
			fillImage.color = Color.red;
		}
		sldr.value = fValue;
		
    }
}
