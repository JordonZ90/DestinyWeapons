using System;
using System.Collections.Generic;
using System.Text;

namespace DestinyWeapons
{
    public class BadJuju : WeaponStats
    {
        public BadJuju()
        {
            
        }

        public BadJuju(int _impact, int _range, int _stability, int _handling, int _reloadspeed, int _aimassistance,
            int _zoom, int _recoildirection, int _magazine)
        {
            Impact = _impact;
            Range = _range;
            Stability = _stability;
            Handling = _handling;
            ReloadSpeed = _reloadspeed;
            Aimassistance = _aimassistance;
            Zoom = _zoom;
            RecoilDirection = _recoildirection;
            Magazine = _magazine;
        }
    }
}
