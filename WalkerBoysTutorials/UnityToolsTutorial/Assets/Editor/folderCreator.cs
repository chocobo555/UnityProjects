using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class folderCreator : MonoBehaviour 
{
	[MenuItem("Project Tools/Make Folder #&g")]
		
	static void MakeFolder()
	{
		GenerateFolders();
	}
	
	
	static void GenerateFolders()
	{
		string projectPath = Application.dataPath + "/";
		
		Directory.CreateDirectory(projectPath + "Scripts");
		Directory.CreateDirectory(projectPath + "Materials");
		Directory.CreateDirectory(projectPath + "Audio");
		Directory.CreateDirectory(projectPath + "Meshes");
		Directory.CreateDirectory(projectPath + "Fonts");
		Directory.CreateDirectory(projectPath + "Shaders");
		Directory.CreateDirectory(projectPath + "Physics");
		Directory.CreateDirectory(projectPath + "Packages");
		Directory.CreateDirectory(projectPath + "prefabs");
		
		AssetDatabase.Refresh();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
