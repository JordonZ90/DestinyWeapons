using System;
using System.Threading;
using System.Threading.Channels;

namespace DestinyWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            HardlightStats();
            BadJujuStats();
            WitherhoardStats();
        }

        public static void HardlightStats()
        {
            Hardlight hardlight = new Hardlight(21, 46, 100, 79, 68, 
                100, 16, 100, 49);

            Console.WriteLine("\tHardlight stats");

            hardlight.WeaponImpact();
            hardlight.WeaponRange();
            hardlight.WeaponStability();
            hardlight.WeaponHandling();
            hardlight.WeaponReloadSpeed();
            hardlight.WeaponAimAssistance();
            hardlight.WeaponZoom();
            hardlight.WeaponRecoilDirection();
            hardlight.WeaponMagazine();

            Console.WriteLine("\n");
            
        }

        public static void BadJujuStats()
        {
            BadJuju badjuju = new BadJuju(27, 46, 79, 60, 52,
                60, 17, 85, 27);

            Console.WriteLine("\tBad Juju stats");

            badjuju.WeaponImpact();
            badjuju.WeaponRange();
            badjuju.WeaponStability();
            badjuju.WeaponHandling();
            badjuju.WeaponReloadSpeed();
            badjuju.WeaponAimAssistance();
            badjuju.WeaponZoom();
            badjuju.WeaponRecoilDirection();
            badjuju.WeaponMagazine();

            Console.WriteLine("\n");
        }

        public static void WitherhoardStats()
        {
            Witherhoard witherhoard = new Witherhoard(8, 21, 71, 100, 40, 
                84, 12, 100, 6);

            Console.WriteLine("\tWitherhoard stats");

            witherhoard.WeaponBlastRadius();
            witherhoard.WeaponVelocity();
            witherhoard.WeaponStability();
            witherhoard.WeaponHandling();
            witherhoard.WeaponReloadSpeed();
            witherhoard.WeaponAimAssistance();
            witherhoard.WeaponZoom();
            witherhoard.WeaponRecoilDirection();
            witherhoard.WeaponMagazine();

            Console.WriteLine("\n");
        }
    }
}
