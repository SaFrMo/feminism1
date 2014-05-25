using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

public class AllDefinitions {

	public AllDefinitions ()
	{
		// Definitions are sourced from a master text file.
		// A single definition in encased within curly braces {}
		// All a definition constructor needs is the text from within those curly braces to create itself


		// split at curly braces
		List<string> toSave = new List<string>();
		MatchCollection m = Regex.Matches(Menu.source, @"(.*)");
		foreach (Capture c in m)
		{
			CreateDefinition(c.Value);
		}
	}

	// master glossary
	public static List<Definition> ALL_DEFINITIONS = new List<Definition>();

	private void CreateDefinition(string src)
	{
		Definition test = new Definition(src);
		ALL_DEFINITIONS.Add (test);
	}
}
