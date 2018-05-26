using System;

namespace PrograZ
{

    public class Soporte : Torres
    {

        public float ralentizacion;
        public float area;



        public Soporte(int vel, int cos, int niv, int vid, float ral, float ar) : base(vel, cos, niv, vid)
        {

            ralentizacion = ral;
            area = ar;

        }

        public void DanioArea()
        {

        }

    }
}