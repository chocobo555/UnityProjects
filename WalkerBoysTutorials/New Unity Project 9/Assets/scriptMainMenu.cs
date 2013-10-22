using UnityEngine;
using System.Collections;

public class scriptMainMenu : MonoBehaviour 
{

	void OnGUI() 
	{
		//make a group on the center of the screen
		GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 80, 100, 175));
		
		//make a box to see the group on screen
		GUI.Box(new Rect(0, 0, 100, 175), "MainMenu");
		
		//add buttons for game navigation
		if (GUI.Button(new Rect(10, 30, 80, 30),"Start Game")) 
		{
			Application.LoadLevel("sceneLoad");
		}
		
		if (GUI.Button(new Rect(10, 65, 80, 30), "Credits")) 
		{
			Application.LoadLevel("sceneCredit");
		}
		
		if (GUI.Button(new Rect(10, 100, 80, 30), "Exit")) 
		{
			Application.Quit();
		}
		
		if (GUI.Button(new Rect(10, 135, 80, 30), "Homepage")) 
		{
			Application.OpenURL("http://the-witness.net/news/");
		}
		
		GUI.EndGroup();
	}
}
