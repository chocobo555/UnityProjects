using UnityEngine;
using System.Collections;

public class scriptAsteroid : MonoBehaviour 
{
	public float asteroidSpeed = 6;
	public Transform explosion;
	public GameObject sceneManager;
	public GameObject shield;
	public AudioClip explosionSound;
	public AudioClip hurtSound;
	
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.down * asteroidSpeed * Time.deltaTime);
		
		Vector3 temp = transform.position;
		if (temp.y <= -8) 
		{
			temp.y = 8;
			temp.x = Random.Range (-6, 6);
			transform.position = temp;
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "player") 
		{
			//other.gameObject.GetComponent<scriptPlayer>().lives -= 1;
			sceneManager.GetComponent<scriptSceneManager>().loseLive();
			
			if (explosion) 
			{
				Instantiate(explosion,transform.position, transform.rotation);
				AudioSource.PlayClipAtPoint(hurtSound, transform.position);
			}
			
			Vector3 temp = transform.position;
			temp.y = 8;
			temp.x = Random.Range (-6, 6);
			transform.position = temp;
			
		}
		
		if (other.gameObject.tag == "shield") 
		{
			shield.GetComponent<scriptShield>().loseShieldHealth();
			
			if (explosion) 
			{
				Instantiate(explosion,transform.position, transform.rotation);
				AudioSource.PlayClipAtPoint(explosionSound, transform.position);
			}
			
			Vector3 temp = transform.position;
			temp.y = 8;
			temp.x = Random.Range (-6, 6);
			transform.position = temp;
		}
	}
	
}

