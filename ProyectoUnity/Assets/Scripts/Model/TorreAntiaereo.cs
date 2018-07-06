﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class TorreAntiaereo : Entidades {

	public int velocidad = 4;
	public int costo = 10;
	public int nivel = 1;
	public int danio = 4;

	public TorreAntiaereo(int vel, int cos, int niv, int dan){

		velocidad = vel;
		costo = cos;
		nivel = niv;
		danio = dan;
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