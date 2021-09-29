using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
	public Slider sl;
	
	public void Volume()
	{
		AudioListener.volume = sl.value;
	}
}
