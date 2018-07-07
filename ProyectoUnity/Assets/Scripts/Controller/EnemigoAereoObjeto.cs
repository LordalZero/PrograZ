using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAereoObjeto : MonoBehaviour {

    private Rigidbody2D rb;
    private EnemigoAereo esteEnemigo;


    void Awake()
    {
        esteEnemigo = new EnemigoAereo();
    }

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
