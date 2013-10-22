using UnityEngine;
using System.Collections;

public class scriptPlayer : MonoBehaviour 
{
	//public int lives 					= 3;
	public float playerSpeedVertical 	= 10;
	public float playerSpeedHorizontal 	= 10;
	public float xAxisMax 				= 6;
	public float xAxisMin 				= -6;
	public float yAxisMax 				= 6;
	public float yAxisMin 				= -6;
	public Transform projectile;
	public Transform socket;
	//public float numberOfShields 		= 3;
	public Transform shieldMesh;
	public bool shieldOn 				= false;
	
	
	// Update is called once per frame
	void Update () 
	{
		float translationVertical = Input.GetAxis("Vertical") * playerSpeedVertical * Time.deltaTime;
        float translationHorizontal = Input.GetAxis("Horizontal") * playerSpeedHorizontal * Time.deltaTime;

		transform.Translate(translationHorizontal, translationVertical, 0);
		
		
		/*
		 if(transform.position.x >= 6)
		 	transform.position.x = 6;
		!!!Error will occur telling you you ned to store the value in a temproary variable!!!
		*/
		Vector3 RestrictPositions = transform.position; //copy to auxilary variable
		if(RestrictPositions.x >= xAxisMax)
			RestrictPositions.x = xAxisMax;//modify components
		if(RestrictPositions.x <= xAxisMin)
			RestrictPositions.x = xAxisMin;//modify components
		if(RestrictPositions.y >= yAxisMax)
			RestrictPositions.y = yAxisMax;//modify components
		if(RestrictPositions.y <= yAxisMin)
			RestrictPositions.y = yAxisMin;//modify components
		transform.position = RestrictPositions;//save modified value
		
		
		if (Input.GetKeyDown("space")) 
		{
			Instantiate(projectile, socket.position, socket.rotation);
			audio.Play();
		}
		
		if (Input.GetKeyDown("e")) 
		{
			if (shieldOn == false) 
			{
				Transform myShieldMesh = Instantiate(shieldMesh, transform.position, transform.rotation) as Transform; //the instantiation spawns as an object, it must be cast as a transform.
			 	myShieldMesh.parent = transform;
				shieldOn = true;
			}

		}
		
	}
} 