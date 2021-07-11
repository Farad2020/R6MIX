using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Data.ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Data.ApplicationDbContext>>()))
            {
                seedSides(context);
                seedLoadouts(context);

                context.SaveChanges();
            }


            void seedSides(Data.ApplicationDbContext context) {
                // Look for any Side.
                /*
                if (context.Side.Any())
                {
                    return;   // DB has been seeded
                }
                */
                foreach (var entity in context.Side)
                    context.Side.Remove(entity);

                context.Side.AddRange(
                    new Side
                    {
                        Name = "Attacker",
                        Icon = "/media/general/attacker.PNG",
                    },
                    new Side
                    {
                        Name = "Defender",
                        Icon = "/media/general/defender.PNG",
                    }
                );
            }

            void seedLoadouts(Data.ApplicationDbContext context)
            {
                // Look for any Side.
                /*
                if (context.Side.Any())
                {
                    return;   // DB has been seeded
                }
                */
                foreach (var entity in context.Loadout)
                    context.Loadout.Remove(entity);

                context.Loadout.AddRange(
                    // Filling Attacker Loadouts
                    new Loadout
                    {
                        Name = "AshLoadout",
                        PrimaryWeapon = "R4-C",
                        PrimaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/primary/R4-C.webp",
                        SecondaryWeapon = "5.7 USG",
                        SecondaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/secondary/5.7_USG.webp",
                        Gadget = "Claymore",
                        GadgetImg = "/media/loadoutImgs/attackerLoadouts/gadget/Claymore.webp",

                    },
                    new Loadout
                    {
                        Name = "ThermiteLoadout",
                        PrimaryWeapon = "556XI",
                        PrimaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/primary/556xi.webp",
                        SecondaryWeapon = "5.7 USG",
                        SecondaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/secondary/5.7_USG.webp",
                        Gadget = "Smoke Grenade",
                        GadgetImg = "/media/loadoutImgs/attackerLoadouts/gadget/Smoke_Grenade.webp",
                    },
                    new Loadout
                    {
                        Name = "ZeroLoadout",
                        PrimaryWeapon = "MP7",
                        PrimaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/primary/MP7.webp",
                        SecondaryWeapon = "GONNE-6",
                        SecondaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/secondary/GONNE-6.webp",
                        Gadget = "Claymore",
                        GadgetImg = "/media/loadoutImgs/attackerLoadouts/gadget/Claymore.webp",
                    },
                    new Loadout
                    {
                        Name = "DokkaebiLoadout",
                        PrimaryWeapon = "MK 14 EBR",
                        PrimaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/primary/Mk_14_EBR.webp",
                        SecondaryWeapon = "SMG-12",
                        SecondaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/secondary/SMG-12.webp",
                        Gadget = "Stun Grenade",
                        GadgetImg = "/media/loadoutImgs/attackerLoadouts/gadget/Stun_Grenade.webp",
                    },
                    new Loadout
                    {
                        Name = "HibanaLoadout",
                        PrimaryWeapon = "TYPE-89",
                        PrimaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/primary/Type-89.webp",
                        SecondaryWeapon = "BEARING 9",
                        SecondaryWeaponImg = "/media/loadoutImgs/attackerLoadouts/secondary/Bearing_9.webp",
                        Gadget = "Breache Charge",
                        GadgetImg = "/media/loadoutImgs/attackerLoadouts/gadget/Breache_Charge.webp",
                    }
                );
            }

        }
    }
}
