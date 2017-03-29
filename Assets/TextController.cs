using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)){
            text.text = "You are in a prison cell, and you want to escape. There are " +
                        "some dirty sheets on the bed, a mirror on the wall, and the door " +
                        "is locked from the outside\n\n" +
                        "Press S to check Sheets, M to check Mirror or L to check Lock.";
        }
	}
}
