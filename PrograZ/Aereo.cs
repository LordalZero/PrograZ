using System;

namespace PrograZ
{
    public class Aereo : Enemigos
    {
        public Aereo(int atk, int vid, int val, int rap) : base(atk, vid, val, rap)
        {

        }

        public float Volar()
        {
            float rap = rapidez;
            return rap;  
        }
        
            
        
    }

}

