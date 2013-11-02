﻿using UnityEngine;
using System.Collections;

public class doorClose : MonoBehaviour 
{
	public GameObject Door;
	public GameObject Player;
	public bool inRange = false;
	public float detectionRange = 5;
	
	
	void OnTriggerEnter (Collider other)
	{
		inRange = true;
	}
	
	
	RaycastHit myHit;
	
	void Update () 
	{	
		if (Physics.Raycast(Player.transform.position, Player.transform.forward, out myHit, detectionRange) && Input.GetMouseButtonDown(0)) //&& inRange == true) 
		{
			print ("hit something");
			Debug.Log(myHit.collider.gameObject.name);
			
			if (myHit.collider.gameObject.tag == "Button2")
			{
				print ("door close animation is playing.");
				Door.animation.Play("DoorClose");	
			}
	
		}
		
	}
}
