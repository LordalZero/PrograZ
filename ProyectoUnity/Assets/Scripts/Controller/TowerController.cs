using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if (torres[towerIndex] == null)
        {
            torres[towerIndex] = new TorreBasica(5, 3, 1, 4);
            Debug.Log("Setting Tower to Slot: " + towerIndex);
        }
    }

    public void AssignIndexTower (int towerSelection)
    {
        towerIndex = towerSelection;
    }

    public void ShowTowerSelectedValues ()
    {

        if (torres[towerIndex] == null)
        {
            Debug.Log("No hay torres en esta casilla");
        } else
        {
            Debug.Log("Torre Numero " + towerIndex + " Velocidad: " + torres[towerIndex].velocidad + " Costo: " + torres[towerIndex].costo + " Nivel: " + torres[towerIndex].nivel + " Ataque: " + torres[towerIndex].danio);

        }
    }

    public void UnassignTower ()
    {
        torres[towerIndex] = null;

    }

    public void TowerCheck ()
    {
        for (int i = 0; i <= torres.Length - 1; i++)
        {
            if (torres[i] != null)
            {
                //GameObject nuevaTorreBasica = Instantiate(torreBasicaObjeto, torresObjeto[towerIndex].transform.position, torresObjeto[towerIndex].transform.rotation) as GameObject;
                //nuevaTorreBasica.transform.parent = canvasGameObj.transform;
                torresObjeto[i].GetComponent<Image>().color = Color.blue;
            } else
            {
                torresObjeto[i].GetComponent<Image>().color = Color.white;
            }
        }
    }

    void Update()
    {
        Debug.Log("Index: " + towerIndex);
    }
}
