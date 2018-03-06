using UnityEngine;

public class PelletPickUp : MonoBehaviour
{
	private int _score;
	UIManager uiManager;

	private void Start()
	{
		uiManager = GameObject.FindWithTag("UI").GetComponent<UIManager>();
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Pellet"))
		{
			_score++;
			Destroy(col.gameObject);
			Debug.Log(_score);
			uiManager.SetScoreText(_score);
		}
	}
}
