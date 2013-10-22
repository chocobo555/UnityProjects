using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour 
{
	public Transform player1;
	
	// Update is called once per frame
	void Update () 
	{
		//transform.position = player1.position;
		
		Vector3 cameraYPosition = transform.position;
		cam = player1.position.y;
		
		transform.position.x = player1.position.x;
	}
}
