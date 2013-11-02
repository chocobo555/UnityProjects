using UnityEngine;
using System.Collections;

public class lowerDoorScriptClose : MonoBehaviour 
{
	public GameObject player;
	public GameObject lowerElevatorDoor;
	public float detectionRange = 50;
	
	
	RaycastHit myHit;
	
	void Update () 
	{
		if (Physics.Raycast(player.transform.position, player.transform.forward, out myHit, detectionRange) 
			&& Input.GetMouseButtonDown(0) 
			&& myHit.collider.gameObject.tag == "lowerDoorButtonClose") 
		{
			lowerElevatorDoor.animation.Play("elevatorDoorLowerClose");
		}
		
	}
}
