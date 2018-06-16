using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsCamera : MonoBehaviour {

	public int Speed = 50;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float xAxixsValue = Input.GetAxis ("Horizontal") * Speed;
		float yAxisValue = Input.GetAxis ("Vertical") * Speed;

		rb.velocity = new Vector2(xAxixsValue, yAxisValue);

		//transform.position = new Vector3 (transform.position.x + xAxixsValue, transform.position.y + yAxisValue, transform.position.z);
		//
		
	}
}
