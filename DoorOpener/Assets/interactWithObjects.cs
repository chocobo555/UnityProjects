using UnityEngine;
using System.Collections;

public class interactWithObjects : MonoBehaviour 
{
	Vector3 Origin;
	Vector3 Direction;
	public float RayCastLength = 50;
	GameObject PlayerCamera;
	GameObject ContextualMessage;
	GUIText ContextualMessageGUIText;
	

	void Start () 
	{
		PlayerCamera = GameObject.Find("First Person Controller/Main Camera");
		ContextualMessage = GameObject.Find("ContextualMessage");
		ContextualMessageGUIText = ContextualMessage.GetComponent<GUIText>();
		ContextualMessageGUIText.enabled = false;
	}
	

	void Update () 
	{
		RaycastHit hit;
		Origin = PlayerCamera.transform.position;
		Direction = PlayerCamera.transform.forward;
		if(Physics.Raycast(Origin, Direction, out hit, RayCastLength))
		{
			print("hit " + hit.collider.name);
			if(hit.collider.gameObject.tag == "InteractiveObject")
			{
				ContextualMessageGUIText.enabled = true;
				InteractiveObject o = hit.collider.GetComponent<InteractiveObject>();
				if (o != null) //might be unnecesary
				{
					ContextualMessageGUIText.text = o.label;
				}
				
			}
			else
			{
				ContextualMessageGUIText.enabled = false;
			}
		}
		else
		{
			ContextualMessageGUIText.enabled = false;
		}
	}
}
