using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MarkovSharp.TokenisationStrategies;
using System.Linq;

public class MarkovTest : MonoBehaviour {

    
    public Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }


    public void GenerateText()
    {
        // Some training data
	var lines = new string[]
	{
		"Frankly, my dear, I don't give a damn.",
		"Mama always said life was like a box of chocolates. You never know what you're gonna get.",
		"Many wealthy people are little more than janitors of their possessions."
	};

	// Create a new model
	var model = new StringMarkov(1);

	// Train the model
	model.Learn(lines);

	// Create some permutations
	
        string txt = model.Walk().First();
        text.text = txt;
    }
}
