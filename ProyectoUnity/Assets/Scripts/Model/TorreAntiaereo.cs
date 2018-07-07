using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class TorreAntiaereo : Entidades {

	public int velocidad;
	public int costo;
	public int nivel;
	public int danio;

	public TorreAntiaereo(){

		velocidad = 5;
		costo = 6;
		nivel = 1;
		danio = 6;
	}

	


	public int Velocidad
	{
		get
		{
			return velocidad;
		}
		set
		{
			velocidad = value;
		}
	}

	public int Costo
	{
		get
		{
			return costo;
		}
		set
		{
			costo = value;
		}
	}

	public int Nivel
	{
		get
		{
			return nivel;
		}
		set
		{
			nivel = value;
		}
	}

	public int Danio
	{
		get
		{
			return danio;
		}
		set
		{
			danio = value;
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
