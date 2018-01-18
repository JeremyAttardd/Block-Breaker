using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    private Ball myBall;

	// Use this for initialization
	void Start () {

        myBall = GameObject.FindObjectOfType<Ball>();

	}
	
	// Update is called once per frame
	void Update () {

        //Save the mouse position in Unity units of the mouse
        //(Depending on the number of units on screen
        float mousePosInUnits = (Input.mousePosition.x / Screen.width * 14f) - 7f;

        //Creates a Vector3 which saves a coordinate
        //In (x, y, z)
        //this.transform.position.y: Keeps the starting y-value
        Vector3 paddlePosition = new Vector3(2f, this.transform.position.y, 0f);

        //Make the paddle move with the mouse
        //paddlePosition.x = Mathf.Clamp(mousePosInUnits, -6.5f, 6.5f);
        paddlePosition.x = Mathf.Clamp(myBall.transform.position.x, -6.5f, 6.5f);


        //Set the position 
        this.transform.position = paddlePosition;

	}
}
