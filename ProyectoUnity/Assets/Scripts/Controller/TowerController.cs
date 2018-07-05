using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {

    public int towerType;
    public int towerIndex;
    public string towerSelection;
    public List<TorreBasica> listaDeTorresBasicas;



	void Start () {
        towerType = 0;
        towerIndex = 0;
        towerSelection = "";
        listaDeTorresBasicas = new List<TorreBasica>();
	}
	

	public void CrearTorrePrueba() {

        TorreBasica torrecitaZero = new TorreBasica(79, 79, 79, 79);
        Debug.Log(torrecitaZero.velocidad);
        Debug.Log(torrecitaZero.danio);
    }

    public void AssignBasicTower2Selection ()
    {
        listaDeTorresBasicas.Insert(towerIndex, new TorreBasica(10, 10, 10, 10));
    }

    public void AssignIndexTower (int towerSelection)
    {
        towerIndex = towerSelection;
    }

    public void ShowTowerSelectedValues ()
    {
        Debug.Log("Torre Numero "+ towerIndex +" Velocidad: " + listaDeTorresBasicas[towerIndex].velocidad + " Costo: " + listaDeTorresBasicas[towerIndex].costo + " Nivel: " + listaDeTorresBasicas[towerIndex].nivel + " Ataque: " + listaDeTorresBasicas[towerIndex].danio);
    }

    void Update()
    {
        Debug.Log("Index: " + towerIndex);
    }
}
