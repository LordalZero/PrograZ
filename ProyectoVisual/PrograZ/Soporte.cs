using System;

namespace PrograZ
{

    public class Soporte : Torres
    {

        float ralentizacion;
        float area;
        public float Ralentizacion { get { return ralentizacion; } set { ralentizacion = value; } }
        public float Area { get { return area; } set { area = value; } }



        public Soporte(int vel, int cos, int niv, int vid, float ral, float ar) : base(vel, cos, niv, vid)
        {

            ralentizacion = ral;
            area = ar;

        }

        public float Danio()
        {
            float ral = ralentizacion;
            return ral;
        }

        public float TamanoArea()
        {
            float ar = area;
            return ar;
        }

    }
}