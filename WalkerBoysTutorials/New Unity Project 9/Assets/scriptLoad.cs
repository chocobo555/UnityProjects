using UnityEngine;
using System.Collections;

public class scriptLoad : MonoBehaviour 
{
	float waitTime = 3;
	
	void OnGUI()
	{	
		//make a group on the center of the screen
		GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 75, 200, 200));
		
		//make a box to see the group on screen
		GUI.Box(new Rect(0, 0, 200, 145), "Instructions");
		
		GUI.Label(new Rect(10, 30, 140, 40), "WASD To move");
		GUI.Label(new Rect(10, 60, 160, 70), "Spacebar to shoot");
		GUI.Label(new Rect(10, 90, 160, 100), "Esc to Quit the game");
		GUI.Label(new Rect(10, 120, 160, 130), "E to activate shield");
		
		GUI.EndGroup();
	}
	
	
	IEnumerator WaitTime()
	{
		yield return new WaitForSeconds(waitTime);
		Application.LoadLevel("Level_01");
	}
	
	
	void Update() 
	{
		if (Input.GetKeyDown("space")) 
		{
			Application.LoadLevel("Level_01");
		}
		else 
		{
			StartCoroutine(WaitTime());
		}
	}
}
