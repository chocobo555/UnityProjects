using UnityEngine;
using System.Collections;

public class scriptWin : MonoBehaviour 
{
	public string winQuote = "You Win";
	
	void OnGUI()
	{
		GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 75, 200, 200));
		
		GUI.Box (new Rect(0, 0, 200, 120), "You Win");
		
		GUI.Label (new Rect(10, 30, 200, 50), "Score: " + PlayerPrefs.GetInt("SCORE"));
		
		if (GUI.Button(new Rect(60, 70, 80, 30), "Main Menu")) 
		{
			Application.LoadLevel("sceneMainMenu");
		}
		
		GUI.EndGroup();
	}


}
