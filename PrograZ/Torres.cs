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

        public void Mejorar()
        {
            nivel = nivel + 1;
            costo = costo * 2;
        }

        public int Velocidad
        {
            get { return velocidad; }
            set { velocidad = value;  }

        }

        public int Costo
        {
            get { return costo; }
            set { costo = value; }

        }

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }

        }

        public int Vida
        {
            get { return vida; }
            set { vida = value; }

        }

        public void Destruir()
        {

        }
    }
}