using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrograZ;

public class Player : Entidades {

	public int vida;
    public int money;
    public float time;




	public Player(float tim){
		
		vida = 50;
        money = 0;
        time = tim;
		
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

    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }

    public float Time
    {
        get
        {
            return time;
        }
        set
        {
            time = value;
        }

    }

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
