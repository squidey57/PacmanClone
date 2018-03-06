using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureMoving : MonoBehaviour {

    private Transform _transform;
    private GameObject _gameObject;

    private float xDirection = 0, yDirection = 0; //Gives the direction that the object should travel in, doesn't move it.
    private float speed = 30f;

	// Use this for initialization
	void Start () {
        _gameObject = gameObject;
        _transform = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)) 
        {
            xDirection = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xDirection = -1;
        }
        else //When the keys are not being pressed, returns back to 0
        {
            xDirection = 0;
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            yDirection = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            yDirection = -1;
        }
        else 
        {
            yDirection = 0;
        }

        _transform.position = new Vector2( (_transform.position.x+xDirection*speed*Time.deltaTime), 
            (_transform.position.y+yDirection*speed*Time.deltaTime) );
	}
}
