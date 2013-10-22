using UnityEngine;
using System.Collections;

public class scriptSceneManager : MonoBehaviour 
{
	float gameTimer = 60;
	static int score = 0;
	static int lives = 3;
	public GameObject player;
	public GameObject shield;
	
	void Update()
	{
		if (lives <= 0) 
		{
			Application.LoadLevel ("sceneLose");
			PlayerPrefs.SetInt("SCORE", score);
			lives = 3;
			score = 0;
		}
		
		if (gameTimer <= 0) 
		{
			Application.LoadLevel ("sceneWin");
			PlayerPrefs.SetInt("SCORE", score);
			lives = 3;
			score = 0;
		}
		
	}
	
	public void Start()
	{
		InvokeRepeating("countDown", 1,1);
	}
	
	public void loseLive()
	{
		print ("Lives:" + lives);	
		lives -= 1;
	}
	
	public void addScore()
	{
		print("Score:" + score);
		score += 1;
	}
	
	public void countDown()
	{
		if (--gameTimer == 0) 
		{
			CancelInvoke("countDown");
		}	
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 20), "Score:" + score);
		GUI.Label(new Rect(170,10, 100, 20), "Lives:" + lives);
		GUI.Label(new Rect(Screen.width -60, 10, 100, 20), "Timer:" + gameTimer);
	}
}
