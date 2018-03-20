using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class Blue_Stat : MonoBehaviour
{


	private bool isHere = false;
	
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			isHere = true;
		}
	}

	private void OnTriggerExit2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			isHere = false;
			
		}
	}

	public bool IsHere()
	{
		return isHere;
	}
}
