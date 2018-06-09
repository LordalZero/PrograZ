using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Inputsplayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E))
            Debug.Log("Torre Destruida");

        if (Input.GetKeyDown(KeyCode.Q))
            Debug.Log("Torre Colocada");
		
	}
}
