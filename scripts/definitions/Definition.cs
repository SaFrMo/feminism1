using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Definition : MonoBehaviour {

	// Topic
	// ===========

	// the word or idea we're defining
	public string word;

	// Definitions
	// ============

	// a tl;dr summary
	public string tldr;
	// a deeper definition
	public string definition;
	/// <summary>
	/// Primary source. Default value is string.Empty - check first in call to make sure
	/// this instance's source isn't string.Empty before including reference
	/// </summary>
	public string primarySource = string.Empty;
	// list of links for further reading
	public List<string> furtherReading = new List<string>();

	// Tags
	// ==========

	// tags for all words or ideas
	// think "history," "radical feminism," "basic term," etc.
	public enum Tag
	{
		BasicTerm
	}

	// tag(s) for this word or idea
	public List<Tag> myTags = new List<Tag>();

}
