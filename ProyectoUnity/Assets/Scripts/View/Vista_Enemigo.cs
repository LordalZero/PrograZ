using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Vista_Enemigo : MonoBehaviour {

    Enemigos enemigos = new Enemigos(10, 5, 5, 80);

    // Use this for initialization
    void Start () {


        

    }
	
	// Update is called once per frame
	void Update () {

		if (enemigos.vida < 1)                                                              //Voy a poner una resta de la vida al llegar a cero se destruye
        {
          
            
            Debug.Log("se destruye este enemigo");     
        }
	}


}
