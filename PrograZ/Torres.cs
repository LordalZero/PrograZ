using System;

namespace PrograZ
{
    public class Torres : Entidades
    {

        public int velocidad;
        public int costo;
        public int nivel;
        public int vida;

        public Torres(int vel, int cos, int niv, int vid)
        {
            velocidad = vel;
            costo = cos;
            nivel = niv;
            vida = vid;

        }

        public void Mejorar(int nivel, int costo)
        {

        }

        public void Destruir()
        {

        }
    }
}