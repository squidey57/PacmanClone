using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

	public Text ScoreText;
	public Text AmmoText;
	
	
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		
	}

	public void SetScoreText(int score)
	{
		ScoreText.text = "The Score is: " + score;
	}

	public void SetAmmoText(int Ammo)
	{
		AmmoText.text = ""+ Ammo;
	}
}

