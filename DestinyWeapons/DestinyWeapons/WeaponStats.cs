using System;
using System.Collections.Generic;
using System.Text;

namespace DestinyWeapons
{
    public class WeaponStats
    {
        private int _impact;
        private int _range;
        private int _stability;
        private int _handling;
        private int _reloadspeed;
        private int _aimassistance;
        private int _zoom;
        private int _recoildirection;
        private int _magazine;

        public int Impact
        {
            get { return _impact; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Impact cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _impact = value;
                }
            }
        }

        public int Range
        {
            get { return _range; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Range cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _range = value;
                }
            }
        }

        public int Stability
        {
            get { return _stability; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Stability cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _stability = value;
                }
            }
        }
        public int Handling
        {
            get { return _handling; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Handling cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _handling = value;
                }
            }
        }
        public int ReloadSpeed
        {
            get { return _reloadspeed; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Reload speed cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _reloadspeed = value;
                }
            }
        }
        public int Aimassistance
        {
            get { return _aimassistance; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Aim assistance cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _aimassistance = value;
                }
            }
        }
        public int Zoom
        {
            get { return _zoom; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Zoom cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _zoom = value;
                }
            }
        }
        public int RecoilDirection
        {
            get { return _recoildirection; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Recoil direction cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _recoildirection = value;
                }
            }
        }
        public int Magazine
        {
            get { return _magazine; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    Console.WriteLine($"Magazine cannot be zero/negative or exceed 100 -----> '{value}' ");
                }
                else
                {
                    _magazine = value;
                }
                Console.WriteLine("\n");
            }
        }


        public void WeaponImpact()
        {
            Console.WriteLine($"Impact rating is '{Impact}'");

        }

        public void WeaponRange()
        {
            Console.WriteLine($"Range rating is '{Range}'");
        }

        public void WeaponStability()
        {
            Console.WriteLine($"Stability rating is '{Stability}'");
        }

        public void WeaponHandling()
        {
            Console.WriteLine($"Handling rating is '{Handling}'");
        }

        public void WeaponReloadSpeed()
        {
            Console.WriteLine($"Reload rating is '{ReloadSpeed}'");
        }

        public void WeaponAimAssistance()
        {
            Console.WriteLine($"Aim assistance rating is '{Aimassistance}'");
        }

        public void WeaponZoom()
        {
            Console.WriteLine($"Zoom rating is '{Zoom}'");
        }

        public void WeaponRecoilDirection()
        {
            Console.WriteLine($"Recoil direction rating is '{RecoilDirection}'");
        }

        public void WeaponMagazine()
        {
            Console.WriteLine($"Magazine size is '{Magazine}'");
        }
    }
}
