using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSlot : MonoBehaviour {

    public int towerSlotState;

	void Awake ()
    {
        towerSlotState = 0;
    }

    void Start()
    {
        InvokeRepeating("Attack", 0, 5);
    }

    void Attack ()
    {
        if (towerSlotState == 1)
        {
            Debug.Log("Basic Tower Attacks");
            // Reducir dmg a enemigo en rango (Falta boundaries de parte de view)
        }
    }
	
}
