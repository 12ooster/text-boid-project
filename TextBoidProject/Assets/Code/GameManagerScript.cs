using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    string TestTextString = "Dearly Beloved, You are like the winter moon, Hanging white-gold in the sky, Both beautiful and with an awakening chill, like a snowflake on the eyelash.";
    string[] splitStrings;
    public GameObject uiTextBoidObject;
    public Canvas canvas;

	// Use this for initialization
	void Start () {
        //Get reference to the canvas
        if ( this.canvas == null ) {
            this.canvas = GameObject.FindObjectOfType<Canvas>();
        }
        //Initialize the array of split strings
        if ( splitStrings == null ) {
            splitStrings = new string[ TestTextString.Split(null).Length ];
        }
        //Parse the given string
        this.splitStrings = this.ParseStrings( TestTextString );
        //Create the UI text object boids
        this.CreateBoids( this.splitStrings );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
        

    string[] ParseStrings( string stringsToParse ){
        return stringsToParse.Split( null );
    }

    /// <summary>
    /// Creates UI objects from a string. One UI object for each word in the string, then parents them to the canvas.
    /// </summary>
    void CreateBoids ( string[] parsedStrings ) {

        if ( uiTextBoidObject == null ) {
            Debug.LogWarning("Missing object! Sought for prefab not found!");
        }else {
            //Iterate through the array of strings and create objects using their text
            for ( int i = 0; i < parsedStrings.Length; i++ ) {
                //Create text object from prefab variable
                GameObject uiTextObj = GameObject.Instantiate( uiTextBoidObject );
                //Parent it to the canvas
                uiTextObj.transform.SetParent(canvas.transform);
                //Set the text of the object to the current string in the array
                uiTextObj.GetComponent<UIBoidTextScript>().SetText( parsedStrings[i] );
            }
        }

    }
}
