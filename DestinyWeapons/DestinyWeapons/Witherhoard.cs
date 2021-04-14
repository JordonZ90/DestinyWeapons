using System;
using System.Collections.Generic;
using System.Text;

namespace DestinyWeapons
{
    public class Witherhoard : WeaponStats
    {
        private int _blastradius;
        private int _velocity;
        public Witherhoard()
        {

        }

        public int BlastRadius
        {
            get { return _blastradius; }
            set // { _blastradius = value; }
             {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Blast radius cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _blastradius = value;
                }
            }
        }

        public int Velocity
        {
            get { return _velocity; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Velocity cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _velocity = value;
                }
            }
        }


        public Witherhoard(int _blastRadius, int _velocity, int _stability, int _handling, int _reloadspeed,
            int _aimassistance, int _zoom, int _recoildirection, int _magazine)
        {
            BlastRadius = _blastRadius;
            Velocity = _velocity;
            Stability = _stability;
            Handling = _handling;
            ReloadSpeed = _reloadspeed;
            Aimassistance = _aimassistance;
            Zoom = _zoom;
            RecoilDirection = _recoildirection;
            Magazine = _magazine;
        }

        public void WeaponBlastRadius()
        {
            Console.WriteLine($"Blast radius is '{BlastRadius}'");
        }

        public void WeaponVelocity()
        {
            Console.WriteLine($"Velocity rating is '{Velocity}'");
        }
    }
}
