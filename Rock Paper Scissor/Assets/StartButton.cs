using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	public void ChangeScene(int SceneLevel)
	{
		SceneManager.LoadScene(SceneLevel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
