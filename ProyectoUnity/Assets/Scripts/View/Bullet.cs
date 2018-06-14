using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Bullet : MonoBehaviour {
    public float force;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 2);
        GetComponent<Rigidbody>().AddForce(this.transform.up * force);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
