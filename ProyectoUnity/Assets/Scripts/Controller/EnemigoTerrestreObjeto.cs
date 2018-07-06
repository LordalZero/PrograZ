using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTerrestreObjeto : MonoBehaviour {

    private Rigidbody2D rb;
    private EnemigoTerrestre esteEnemigo;


    void Awake ()
    {
        esteEnemigo = new EnemigoTerrestre(5, 10, 6, 6);
    }

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = Vector2.right * 10 * esteEnemigo.rapidez;

        if (esteEnemigo.vida < 1)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
       // Reservado para View
    }
}
