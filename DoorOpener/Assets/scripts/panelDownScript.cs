using UnityEngine;
using System.Collections;

public class panelDownScript : MonoBehaviour 
{
	public GameObject player;
	public GameObject elevatorPlatform;
	public float detectionRange = 50;
	
	
	RaycastHit myHit;
	
	void Update () 
	{
		if (Physics.Raycast(player.transform.position, player.transform.forward, out myHit, detectionRange) 
			&& Input.GetMouseButtonDown(0) 
			&& myHit.collider.gameObject.tag == "panelDownButton") 
		{
			elevatorPlatform.animation.Play("elevatorPlatformDown");
		}
		
	}
}
