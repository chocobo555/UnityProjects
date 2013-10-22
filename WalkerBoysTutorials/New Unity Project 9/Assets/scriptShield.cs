using UnityEngine;
using System.Collections;

public class scriptShield : MonoBehaviour 
{
	static int shieldHealth = 3;
	public GameObject player;
	
	
	public void loseShieldHealth()
	{
		shieldHealth -= 1;
	}
	
	
	// Update is called once per frame
	void Update() 
	{
		if (shieldHealth <= 0) 
		{
			player.GetComponent<scriptPlayer>().shieldOn = false;
			
			Destroy(gameObject);
			
			shieldHealth = 3;
		}
		
	}
}
