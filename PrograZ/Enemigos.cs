using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Enemigos : Entidades 
{
    public int ataque;
    public int vida;
    public int valor;
    public int rapidez;

    public Enemigos(int atk, int vid, int val, int rap)
    {
        ataque = atk;
        vida = vid;
        valor = val;
        rapidez = rap;
    }

    public int Ataque { get; set; }
    public int Vida { get; set; }
    public int Rapidez { get; set; }
    public int Valor { get; set; }

	public void golpear()
	{
		
	}
}
