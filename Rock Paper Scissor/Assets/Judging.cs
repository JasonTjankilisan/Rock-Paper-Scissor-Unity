using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judging : MonoBehaviour {
	public GameObject Choice1;
	public GameObject Choice2;
	public Sprite[] List;
	public Text AnnouncementText;
	// Use this for initialization
	
	public GameObject[] RemovedObject;
	public GameObject[] AddedObject;
	
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	public void decideWhosVictory (int Choice)
	{
		int computerchoice = Random.Range(0,3);
		SpriteRenderer x = Choice1.GetComponent<SpriteRenderer>();
		SpriteRenderer y = Choice2.GetComponent<SpriteRenderer>();
		//0=rock, 1=Paper, 2=Scissors
		Debug.Log(Choice + "VS" + computerchoice);
		x.sprite = List[Choice];
		y.sprite = List[computerchoice];
		
		if(Choice==computerchoice)
		{
			AnnouncementText.text = "Draw!";
		}
		else if((Choice==1&computerchoice==0) || (Choice==2&computerchoice==1) || (Choice==0&computerchoice==2))
		{
			AnnouncementText.text = "Player 1 Win!";
		}
		else if((Choice==0&computerchoice==1) || (Choice==1&computerchoice==2) || (Choice==2&computerchoice==0))
		{
			AnnouncementText.text = "Player 2 Win!";
		}
	}
	
	public void ClearUI ()
	{
		for(int count=0;count<RemovedObject.Length;count++)
		{
			RemovedObject[count].SetActive(false);
		}
		
		for(int count=0;count<AddedObject.Length;count++)
		{
			AddedObject[count].SetActive(true);
		}
	}
}
