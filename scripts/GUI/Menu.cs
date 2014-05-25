using UnityEngine;
using System.Collections;
using System.IO;

public class Menu : MonoBehaviour {

	public static string source;

	AllDefinitions GLOSSARY;

	private void Start ()
	{

		// load the source file
		//TextAsset t = Resources.Load("definitions.txt") as TextAsset;
		StreamReader t = new StreamReader ("Assets/definitions.txt");
		source = t.ReadToEnd();
		print ("this:" + source);
		Current = Position.Welcome;
		AllDefinitions GLOSSARY = new AllDefinitions();
	}

	// constructs the glossary at start


	// menu state
	public enum Position
	{
		Welcome
	}

	public Position Current { get; private set; }

	// GUI FUNCTIONS
	// ==================
	private void WelcomeScreen ()
	{

	}



	// ON GUI()
	// ==================
	private void OnGUI ()
	{

	}


	

}
