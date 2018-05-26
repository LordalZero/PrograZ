using System;

public class Soporte : Torres
{

    public float ralentizacion;
    public float area;



    public Soporte(int vel, int cos, int niv, int vid, float ral, float ar) : base(vel, cos, niv, vid, ral, ar)
    {

        ralentizacion = ral;
        area = ar;

    }

    public void DanioArea()
    {

    }

}
