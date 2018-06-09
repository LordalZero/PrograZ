using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograZ
{
    class Jugador : Entidades
    {
        int hp;
        public int dinero;
        public int puntaje;
        public int Hp { get { return hp; } set { hp = value; } }

        public Jugador(int _hp, int _dinero, int _puntaje)
        {
            dinero = _dinero;
            hp = _hp;
            puntaje = _puntaje;
        }
    }
}
