using UnityEngine;
using System.Collections;

public class nameObject : MonoBehaviour 
{
	RaycastHit myHit;
	public GameObject player;
	float detectionRange = 50;
	string namedObject;
	
	
	void Start() { }
	

	void Update() 
	{
		if (Physics.Raycast(player.transform.position, player.transform.forward, out myHit, detectionRange)) 
		{
			namedObject = myHit.collider.gameObject.name;
		}
	}
	
	
	void OnGUI()
	{
		GUI.Label(new Rect(470, 275, 100, 20), namedObject);
	}
}
