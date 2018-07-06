using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Player : Entidades {

	public int vida;




	public Player(int hp){
		
		vida = hp;
		
	}

	public Player myPlayer = new Player (50);

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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
