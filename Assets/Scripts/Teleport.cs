using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	private Blue_Stat _bluePortal, _orangePortal ;
	private GameObject _target;
	
	
	// Use this for initialization
	void Start ()
	{
		_bluePortal = transform.GetChild(0).GetComponent<Blue_Stat>();
		_orangePortal = transform.GetChild(1).GetComponent<Blue_Stat>();
		_target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if (_bluePortal.IsHere().Equals(true))
		{
			_target.transform.position = new Vector2(-60,3);
		}

		if (_orangePortal.IsHere().Equals(true))
		{
			_target.transform.position = new Vector2(60,3);
		}
	}
}
