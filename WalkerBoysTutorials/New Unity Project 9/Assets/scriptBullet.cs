using UnityEngine;
using System.Collections;

public class scriptBullet : MonoBehaviour 
{
	public float bulletSpeed = 15;
	public float bulletRange = 10;
	public Transform explosion;
	public GameObject sceneManager;
	public AudioClip clip;
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
		
		if (transform.position.y >= bulletRange) 
		{
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "asteroid") 
		{
			Vector3 temp = other.transform.position;
			temp.y = 8;
			temp.x = Random.Range(-6, 6);
			other.transform.position = temp;
			
			Instantiate (explosion.gameObject, transform.position, transform.rotation);
			AudioSource.PlayClipAtPoint(clip, transform.position);
			
			sceneManager.GetComponent<scriptSceneManager>().addScore();
			
			Destroy (gameObject);
		}
	}
}
