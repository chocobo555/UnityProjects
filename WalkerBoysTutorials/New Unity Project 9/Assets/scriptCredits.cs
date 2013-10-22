using UnityEngine;
using System.Collections;

public class scriptCredits : MonoBehaviour 
{	
	void OnGUI()
	{
		GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 75, 200, 200));
		
		GUI.Box(new Rect(0, 0, 200, 200), "Credits");
		
		GUI.Label(new Rect(10, 30, 200, 50), 	"Designer				Ian Harris");
		GUI.Label(new Rect(10, 60, 200, 80), 	"Artist						Ian Harris");
		GUI.Label(new Rect(10, 90, 200, 110), 	"Software				Ian Harris");
		GUI.Label(new Rect(10, 120, 200, 140),	"Level Design			Ian Harris");
		
		if (GUI.Button(new Rect(60, 155, 80, 30), "Back")) 
		{
			Application.LoadLevel("sceneMainMenu");
		}

		
		GUI.EndGroup();
	}
}
