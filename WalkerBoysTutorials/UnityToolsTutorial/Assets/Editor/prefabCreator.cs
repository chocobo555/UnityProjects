using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class prefabCreator : MonoBehaviour 
{
	[MenuItem("Project Tools/Make Prefab")]
	
	static void makePrefab()
	{
		GameObject[] selectedObjects = Selection.gameObjects;
		Debug.Log(selectedObjects[0].name);
		
		for (GameObject go in selectedObjects) 
		{
			print(go.name);
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
