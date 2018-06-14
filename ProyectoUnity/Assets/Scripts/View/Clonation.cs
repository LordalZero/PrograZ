using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonation : MonoBehaviour {
    public GameObject bullet;
    public Transform cannon;
    public float firerate = 1.0f;
    private float lastfire;
	// Use this for initialization
	void Start () {
        lastfire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

            Instatiatebullet();
       
	}
    void Instatiatebullet()
    {
        if (lastfire < Time.time)
        {
            lastfire = Time.time + firerate;
            Instantiate(bullet, cannon.transform.position, cannon.transform.rotation);
        }
    }
}
