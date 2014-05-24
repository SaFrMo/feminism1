using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class AllDefinitions {

	public AllDefinitions ()
	{
		// Definitions are sourced from a master text file.
		// A single definition in encased within curly braces {}
		// All a definition constructor needs is the text from within those curly braces to create itself

		// first, locate the 

		//string[] toSave = Regex.Split ();
		CreateDefinitions();
	}

	// master glossary
	public static List<Definition> ALL_DEFINITIONS = new List<Definition>();

	private void CreateDefinitions()
	{
		Definition test = new Definition("<word>YEP</word>asdasdasdad<tldr>TL;DR</tldr>");
	}
}
