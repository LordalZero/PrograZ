using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace PrograZ
{
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

        public int Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        public int Rapidez
        {
            get { return rapidez; }
            set { rapidez = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public void Golpear()
        {
            ataque = 0;
        }
    }

}

   
