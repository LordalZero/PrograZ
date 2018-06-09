using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograZ
{
    public class Terrestres : Enemigos
    {
        public Terrestres(int atk, int vid, int val, int rap):base(atk, vid, val,rap)
        {
          
        }
        public float Mover()
        {
            float rap = rapidez;
            return rap;
        }
    }
}
