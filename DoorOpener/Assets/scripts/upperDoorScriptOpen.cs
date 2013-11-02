using UnityEngine;
using System.Collections;

public class upperDoorScriptOpen : MonoBehaviour 
{
	public GameObject player;
	public GameObject upperElevatorDoor;
	public float detectionRange = 50;
	
	
	RaycastHit myHit;
	
	void Update () 
	{
		if (Physics.Raycast(player.transform.position, player.transform.forward, out myHit, detectionRange) 
			&& Input.GetMouseButtonDown(0) 
			&& myHit.collider.gameObject.tag == "upperDoorButtonOpen") 
		{
			upperElevatorDoor.animation.Play("elevatorDoorUpperOpen");
		}
		
	}
	
}
