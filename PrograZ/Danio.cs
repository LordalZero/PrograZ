using System;


namespace PrograZ
{
    public class Danio : Torres
    {

        public int damage;



        public Danio(int vel, int cos, int niv, int vid, int dam) : base (vel, cos, niv, vid)
        {

            damage = dam;

        }

        public void Atacar()
        {

        }

    }
}