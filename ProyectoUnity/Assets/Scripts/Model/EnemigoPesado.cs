using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class EnemigoPesado {

	public int ataque = 10;
	public int vida = 20;
	public int valor = 15;
	public int rapidez = 1;

	public EnemigoPesado(int atk, int vid, int val, int rap){
		ataque = atk;
		vida = vid;
		valor = val;
		rapidez = rap;
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
