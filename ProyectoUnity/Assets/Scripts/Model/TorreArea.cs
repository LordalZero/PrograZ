using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class TorreArea : Entidades {

	public int velocidad = 6;
	public int costo = 5;
	public int nivel = 1;
	public int area = 3;
	public int danio = 3;

	public TorreArea(int vel, int cos, int niv, int are, int dan){

		velocidad = vel;
		costo = cos;
		nivel = niv;
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
