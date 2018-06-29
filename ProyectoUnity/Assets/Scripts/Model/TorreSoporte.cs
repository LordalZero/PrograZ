using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class TorreSoporte {

	public int velocidad;
	public int costo;
	public int nivel;
	public int ralentizacion;
	public int area;
	public int danio;

	public TorreSoporte(int vel, int cos, int niv, int ral, int are, int dan){

		velocidad = vel;
		costo = cos;
		nivel = niv;
		ralentizacion = ral;
		area = are;
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

	public int Ralentizacion
	{
		get
		{
			return ralentizacion;
		}
		set
		{
			ralentizacion = value;
		}
	}

	public int Area
	{
		get
		{
			return area;
		}
		set
		{
			area = value;
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
