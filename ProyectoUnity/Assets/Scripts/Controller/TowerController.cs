using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {

    public int towerType;
    public int towerIndex;
    public string towerSelection;
    //public List<TorreBasica> listaDeTorresBasicas;
    public TorreBasica[] torres;
    public GameObject[] torresObjeto;
    public GameObject torreBasicaObjeto;
    public GameObject canvasGameObj;




	void Start () {
        torres = new TorreBasica[8];
        towerType = 0;
        towerIndex = 0;
        towerSelection = "";
        //listaDeTorresBasicas = new List<TorreBasica>();
	}
	

	public void CrearTorrePrueba() { // Debuggin Purposes

        TorreBasica torrecitaZero = new TorreBasica(79, 79, 79, 79);
        Debug.Log(torrecitaZero.velocidad);
        Debug.Log(torrecitaZero.danio);
    }

    public void AssignBasicTower2Selection ()
    {
        //listaDeTorresBasicas.Insert(towerIndex, new TorreBasica(10, 10, 10, 10));
        torres[towerIndex] = new TorreBasica(5,3,1,4);
    }

    public void AssignIndexTower (int towerSelection)
    {
        towerIndex = towerSelection;
    }

    public void ShowTowerSelectedValues ()
    {
        Debug.Log("Torre Numero "+ towerIndex +" Velocidad: " + torres[towerIndex].velocidad + " Costo: " + torres[towerIndex].costo + " Nivel: " + torres[towerIndex].nivel + " Ataque: " + torres[towerIndex].danio);
    }

    public void UnassignTower ()
    {

    }

    public void TowerCheck ()
    {
        for (int i = 0; i <= torres.Length - 1; i++)
        {
            if (torres[i] != null)
            {
                GameObject nuevaTorreBasica = Instantiate(torreBasicaObjeto, torresObjeto[towerIndex].transform.position, torresObjeto[towerIndex].transform.rotation) as GameObject;
                nuevaTorreBasica.transform.parent = canvasGameObj.transform;
                Debug.Log("Setting Tower to Slot: " + towerIndex);
            }
        }
    }

    void Update()
    {
        Debug.Log("Index: " + towerIndex);
    }
}
