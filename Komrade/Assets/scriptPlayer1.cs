using UnityEngine;
using System.Collections;

public class scriptPlayer1 : MonoBehaviour 
{
	// Update is called once per frame
	void FixedUpdate() 
	{	
		rigidbody.useGravity = true;
		
		rigidbody.AddForce(Vector3.left * 20);
		rigidbody.AddForce(Vector3.down * 40);
		
		rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
	}
	
}
