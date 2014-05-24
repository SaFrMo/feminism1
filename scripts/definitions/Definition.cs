using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Definition  {

	private string GetGlossaryData (string tag, string source)
	{
		string closeTag = tag.Insert(1, "/");
		string regex = string.Format ("(?<={0}).*?(?={1})", tag, closeTag);
		try 
		{
			Match word = Regex.Match (source, @regex);
			string result = word.Groups[0].Value;
			if (result == string.Empty) result = "- not found -";
			return result;
		}
		catch { MonoBehaviour.print ("Couldn't find " + tag); return "-NOTFOUND-"; }
	}

	public Definition (string source)
	{
		// the word itself
		Word = GetGlossaryData("<word>", source);
		TLDR = GetGlossaryData("<tldr>", source);
		DeeperDefinition = GetGlossaryData("<definition>", source);
		PrimarySource = GetGlossaryData("<primary>", source);
		MonoBehaviour.print ( Word + TLDR + DeeperDefinition + PrimarySource);
	}

	// Topic
	// ===========

	// the word or idea we're defining
	public string Word { get; private set; }

	// Definitions
	// ============

	// a tl;dr summary
	public string TLDR { get; private set; }
	// a deeper definition
	public string DeeperDefinition { get; private set; }
	/// <summary>
	/// Primary source. Default value is string.Empty - check first in call to make sure
	/// this instance's source isn't string.Empty before including reference
	/// </summary>
	public string PrimarySource { get; private set; }
	// list of links for further reading
	//public List<string> FurtherReading { get; private set; }

	/*
	// Tags - TODO LATER IN PROCESS
	// ==========

	// tags for all words or ideas
	// think "history," "radical feminism," "basic term," etc.
	public enum Tag
	{
		BasicTerm
	}

	// tag(s) for this word or idea
	public List<Tag> myTags = new List<Tag>();
	*/

}
