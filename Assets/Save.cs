using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public static void SaveD()
	{
		PlayerPrefs.SetInt("money",Data.Zloto);
		PlayerPrefs.SetInt("almaz",Data.Almaz);
	}
	public void LoadD()
	{
		Data.Zloto = PlayerPrefs.GetInt("money");
		Data.Almaz = PlayerPrefs.GetInt("almaz");
	}
	void Start()
    {
		LoadD();
	}
	public void SaveScene()
	{
		int thisScene = SceneManager.GetActiveScene().buildIndex;
		if(thisScene >= PlayerPrefs.GetInt("scenes"))
		{
			PlayerPrefs.SetInt("scenes", thisScene +1);
		}
	}
	public void SaveAll()
	{
		SaveD();
		SaveScene();
	}
	
	public void DeletData()
	{
	PlayerPrefs.DeleteAll();
	}
}
