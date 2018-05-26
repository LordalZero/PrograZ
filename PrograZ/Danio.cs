using System;


namespace Practica
{
    public class Danio : Torres
    {

        public int damage;



        public Danio(int vel, int cos, int niv, int vid, int dam) : base(vel, cos, niv, vid, dam)
        {

            damage = dam;

        }

        public void Atacar()
        {

        }

    }
}