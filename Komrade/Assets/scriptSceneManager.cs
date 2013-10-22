using UnityEngine;
using System.Collections;

public class scriptSceneManager : MonoBehaviour 
{

	
	// Update is called once per frame
	void FixedUpdate() 
	{
		Physics.gravity = new Vector3(0, -10, 0);
	}
}
