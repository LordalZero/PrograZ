using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Vista_Enemigo : MonoBehaviour
{


    Enemigos enemigos = new Enemigos(10, 5, 5, 80);
    int x;

    // Use this for initialization
    void Start()
    {
        enemigos.vida = x;



    }

    // Update is called once per frame
    void Update()
    {

        if (x == 0)
        {
            x = x - 1;

            Debug.Log("Se Elimino un enemigo");
            //Destroy(gameObject);


        }

    }


}