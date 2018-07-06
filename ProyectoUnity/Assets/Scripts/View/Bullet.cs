using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Bullet : MonoBehaviour {

    public float force;
    [HideInInspector] public Transform target;
    private Vector3 lookDirection;


    // Use this for initialization
    void Start () {
        Destroy(this.gameObject, 10);
    }

    void Update() {
        lookDirection = (target.position - transform.position).normalized;
        transform.Translate(lookDirection * force * Time.deltaTime, Space.World);
    }
}