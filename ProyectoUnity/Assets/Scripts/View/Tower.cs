using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
    public GameObject target;
    public bool Look;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Look == true)
        {
            transform.LookAt(target.transform.position);
            
        }
    }
}
