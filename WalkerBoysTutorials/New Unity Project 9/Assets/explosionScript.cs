using UnityEngine;
using System.Collections;

public class explosionScript : MonoBehaviour 
{

	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "asteroid") 
		{	
			Destroy (gameObject);
		}	
	}
}
