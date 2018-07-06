using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tower : MonoBehaviour {
    public GameObject target;
    public bool Look;

    public GameObject bullet;
    public Transform cannon;
    public float firerate = 1.0f;
    private float lastfire;


    void Update () {
        if (Look == true) {
            transform.LookAt(target.transform.position);
        }
        Instatiatebullet();
    }

    void Instatiatebullet() {
        if (lastfire < Time.time) {
            lastfire = Time.time + firerate;
            GameObject bulletClone = Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            bulletClone.GetComponent<Bullet>().target = target.transform;
        }
    }
}