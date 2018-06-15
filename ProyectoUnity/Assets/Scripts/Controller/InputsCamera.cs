using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsCamera : MonoBehaviour {

	public int Speed = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float xAxixsValue = Input.GetAxis ("Horizontal") * Speed;
		float yAxisValue = Input.GetAxis ("Vertical") * Speed;

		transform.position = new Vector3 (transform.position.x + xAxixsValue, transform.position.y + yAxisValue, transform.position.z);
		
	}
}
