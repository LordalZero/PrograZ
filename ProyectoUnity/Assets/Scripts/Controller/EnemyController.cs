using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject enemigoTerrestre;
    public GameObject enemigoAereo;
    public GameObject canvasGameObj;
    public int respawnTime;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 0, respawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnEnemy ()
    {
        int numerorandom = Random.Range(0,2);
        if(numerorandom == 0)
        {
            GameObject nuevoEnemigoTerrestre = Instantiate(enemigoTerrestre, transform.position, transform.rotation) as GameObject;
            nuevoEnemigoTerrestre.transform.parent = canvasGameObj.transform;
        } else
        {
            GameObject nuevoEnemigoAereo = Instantiate(enemigoAereo, transform.position, transform.rotation) as GameObject;
            nuevoEnemigoAereo.transform.parent = canvasGameObj.transform;
        }
        
    }
}
