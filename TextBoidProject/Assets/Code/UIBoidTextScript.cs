using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBoidTextScript : MonoBehaviour {

    Text uiText;

	
    void Awake () {
        if ( this.uiText == null ) {
            this.uiText = this.GetComponent<Text>();
        }
    }

    // Use this for initialization
	void Start () {
        if ( this.uiText == null ) {
            this.uiText = this.GetComponent<Text>();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Sets the text of this UI element.
    /// </summary>
    /// <param name="newText">New text.</param>
    public void SetText( string newText ){

        if( this.uiText == null ){
            Debug.LogWarning("Missing component! Looked for component null in script.");
        }else{
            this.uiText.text = newText;
        }

    }
}
