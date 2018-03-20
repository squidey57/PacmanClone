using UnityEngine;

public class EnemyCollision : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Enemy"))
        	{
        		Destroy(gameObject);
        			
        	}
	}
}

