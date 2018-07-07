using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class EnemigoTerrestre {

	public int ataque;
	public int vida;
	public int valor;
	public int rapidez;

	public EnemigoTerrestre(){

		ataque = 6;
		vida = 10;
		valor = 8;
		rapidez = 10;
	}

	


	public int Ataque
	{
		get 
		{
			return ataque;
		}
		set 
		{
			ataque = value;
		}

	}

	public int Vida
	{
		get
		{
			return vida;
		}
		set 
		{
			vida = value;
		}
	}

	public int Valor 
	{
		get 
		{
			return valor;
		}
		set 
		{
			valor = value;
		}
	}

	public int Rapidez 
	{
		get 
		{
			return rapidez;
		}
		set
		{
			rapidez = value;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
