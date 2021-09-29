using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void SceneLoad(int sn)
    {
        SceneManager.LoadScene(sn);
    }
	public void NextScene()
	{
		if(PlayerPrefs.GetInt("scenes") <= 0)
		{
			SceneManager.LoadScene(1);
		}else if(PlayerPrefs.GetInt("scenes") > 5)
		{
			SceneManager.LoadScene(1);
		}else
		{
			SceneManager.LoadScene(PlayerPrefs.GetInt("scenes"));
		}
		
	}
    public void Exit()
    {
        Application.Quit();
    }
	
	public void PauseG()
	{
		Time.timeScale = 0f;
	}
	public void ResumeG()
	{
		Time.timeScale = 1f;
	}
	public void Delet()
	{
		PlayerPrefs.DeleteAll();
	}
	
}
