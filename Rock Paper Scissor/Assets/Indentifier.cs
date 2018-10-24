using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indentifier : MonoBehaviour {

	private int typeSended=0;
	void Start () 
	{
		if (transform.name == "Rock")
		{
			typeSended=1;
		}
		if (transform.name == "Paper")
		{
			typeSended=2;
		}
		if (transform.name == "Scissors")
		{
			typeSended=3;
		}
		Debug.Log(typeSended + " Is Recognized");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
