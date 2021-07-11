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
                seedOperators(context);

                context.SaveChanges();
            }

            void seedSides(Data.ApplicationDbContext context) {
                // Look for any Side.
                if (context.Side.Any())
                {
                    return;   // DB has been seeded
                }
                /*
                foreach (var entity in context.Side)
                    context.Side.Remove(entity);
                */
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

                context.SaveChanges();
            }

            void seedLoadouts(Data.ApplicationDbContext context)
            {
                // Look for any Loadout.
                if (context.Loadout.Any())
                {
                    return;   // DB has been seeded
                }

                /*
                foreach (var entity in context.Loadout)
                    context.Loadout.Remove(entity);
                */

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
                        Gadget = "Breach Charge",
                        GadgetImg = "/media/loadoutImgs/attackerLoadouts/gadget/Breach_Charge.webp",
                    },

                    //DefenderLoadouts
                    new Loadout
                    {
                        Name = "AruniLoadout",
                        PrimaryWeapon = "P10 RONI",
                        PrimaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/primary/p10roni.png",
                        SecondaryWeapon = "PRB92",
                        SecondaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/secondary/PRB92.webp",
                        Gadget = "Barbed Wire",
                        GadgetImg = "/media/loadoutImgs/defenderLoadouts/gadget/Barbed_wire.webp",
                    },
                    new Loadout
                    {
                        Name = "WardenLoadout",
                        PrimaryWeapon = "MPX",
                        PrimaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/primary/MPX.webp",
                        SecondaryWeapon = "P-10C",
                        SecondaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/secondary/P-10C.webp",
                        Gadget = "Nitro Cell",
                        GadgetImg = "/media/loadoutImgs/defenderLoadouts/gadget/Nitro_Cell.webp",
                    },
                    new Loadout
                    {
                        Name = "LesionLoadout",
                        PrimaryWeapon = "T-5 SMG",
                        PrimaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/primary/T-5_SMG.webp",
                        SecondaryWeapon = "Q-929",
                        SecondaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/secondary/Q-929.webp",
                        Gadget = "Bulletproof Camera",
                        GadgetImg = "/media/loadoutImgs/defenderLoadouts/gadget/Bulletproof_camera.webp",
                    },
                    new Loadout
                    {
                        Name = "ElaLoadout",
                        PrimaryWeapon = "SCORPION EVO 3 A1",
                        PrimaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/primary/Scorpion_EVO_3_A1.webp",
                        SecondaryWeapon = "RG15",
                        SecondaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/secondary/RG15.webp",
                        Gadget = "Deployable Shield",
                        GadgetImg = "/media/loadoutImgs/defenderLoadouts/gadget/Deployable_Shield.webp",
                    },
                    new Loadout
                    {
                        Name = "EchoLoadout",
                        PrimaryWeapon = "MP5SD",
                        PrimaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/primary/MP5SD.webp",
                        SecondaryWeapon = "P229 RC",
                        SecondaryWeaponImg = "/media/loadoutImgs/defenderLoadouts/secondary/P229.webp",
                        Gadget = "Impact Grenade",
                        GadgetImg = "/media/loadoutImgs/defenderLoadouts/gadget/Impact_Grenade.webp",
                    }
                );

                context.SaveChanges();
            }

            void seedOperators(Data.ApplicationDbContext context)
            {
                // Look for any Side.
                /*
                if (context.Operator.Any())
                {
                    return;   // DB has been seeded
                }
                */

                foreach (var entity in context.Operator)
                    context.Operator.Remove(entity);

                context.Operator.AddRange(
                    //Defenders
                    new Operator
                    {
                        Name = "Warden",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/wardenPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/warden.png",
                        Role = "Anchor, Intel Denier",
                        Origin = "Secret Service",
                        Biography = "\"I'm never unprepared.\" \nCollinn McKinley enrolled in the Marine Corps at 18 and earned several commendations in his service jacket for his aggressive quick-thinking, achieving Master Sergeant despite a few minor infractions on his record. After his third tour, he left the Marines and entered the Secret Service in close-protection detail. McKinley’s agility was instrumental in saving Secretary of State Baldwin’s life when insurgents attacked the U.S. diplomatic junket. Baldwin later went on to win the U.S. Presidential and requested McKinley be assigned to the Presidential Protective Division. McKinley has spent over a decade in Washington, protecting important political figures. He is the foremost expert in close protection detail, and with President Baldwin finishing his second term, McKinley has received high endorsements for his transition into Rainbow.",
                        PshycoPortrait = "I’ve learned to read between the lines, and when it comes to Specialist Collinn \"Warden\" McKinley, that’s where the real story lies. His role as protector came easily to him between butting heads with his strict, hardworking father and defending his brothers at school, but it became more deeply engrained during his three tours with the Marines.\nMcKinley’s service with the Secret Service reads like a Washington gossip column/spy novel. During the attack on then Secretary-of-State Baldwin, the attackers used flashbangs, smoke grenades, and heavy suppressing fire to separate the protection detail. McKinley realized all their evacuation routes had been compromised and evacuated Baldwin alone. The incident clarified the reason behind McKinley’s special glasses, but it’s also become indicative of his modus operandi… his off-the-cuff attitude. He’s never been wrong and I fear he’ll rely on instinct until it finally fails him.\nHis access to the inner circle through the Office of the President made him the go-to in handling delicate situations. He’s clever enough to lead people on the right track without implicating himself and I suspect he knows where a few bodies are buried. McKinley has amassed quite the war chest of political favors and a reputation as a lady’s man. President Baldwin once told me that McKinley’s dalliances eclipsed that of some Presidential administrations. The First Lady was displeased with that joke.\nHe knows how to manipulate; he deepens his Kentucky drawl when dealing with Republican senators, and plays the Southern gentleman around women. I was amused, watching him try to play to my personality… but I play the game too.\nMcKinley adores his teams and he works well with others, but his connection to the Oval Office has instilled him with a sense of invulnerability. McKinley has made many enemies among politicians, businessmen, and Lobbyists; he’s a walking encyclopedia of their sins, and President Baldwin won’t be around to protect him anymore.\nHe is the sort of non-traditional approach we need to keep the military and law enforcement more agile and surgical, someone who understands coordination on a large scale. Unfortunately, that means I owe President Baldwin a 25-year old single malt Scotch for recommending McKinley; he’s insufferable when he’s right.\n-- Dr. Harishva Pandey",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 2,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "WardenLoadout").FirstOrDefault(),
                        AbilityName = "GLANCE SMART GLASSES",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Glance-Smart-Glasses.webp",
                        AbilityTLDR = "The Glance serves a function that was almost non-existent on the Defending team. With it active, Warden can see through smoke and turn around what could be a low-intel situation. Activating his Smart Glasses can also prevent Warden from being blinded by flash effects, or cleanse an existing flash blindness, salvaging an otherwise dangerous few seconds. However, the Glance’s thermal vision only works as long as Warden stays immobile; otherwise, he is affected by smoke the same as everyone else. The Glance is a triggered effect, which must be restored through a cooldown after use.",
                        AbilityDemoLink = "https://youtu.be/qpZBD30L7fo"
                    },
                    new Operator
                    {
                        Name = "Aruni",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/aruniPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/aruni.png",
                        Role = "Secure, Intel Gatherer, Anchor",
                        Origin = "NIGHTHAVEN",
                        Biography = "“In every conflict, it’s the children who are made to suffer, even after the fighting has stopped.”\nAs a private detective, her discovery of a bomb plot in Bangkok brought Aruni to the attention of the Royal Thai Police (RTP). Her knack for connecting the dots between seemingly-unrelated incidents earned her grudging respect from Thailand’s male-dominated law enforcement agencies, as well as hostility from numerous criminal syndicates.\nThe RTP offered Aruni a Detective position with the Crime Suppression Division, where she dismantled a human trafficking ring and foiled no fewer than four bomb plots. Her ability to track and connect diverse shipments of explosive materials was lauded by her superiors. Unfortunately, Aruni’s police career ended when she was nearly killed during an operation in Bangkok.\nFollowing her recovery, Aruni was approached by Jaimini “Kali” Shah. Kali’s access to cutting-edge prosthetics was likely a factor in Aruni’s decision to join Nighthaven.",
                        PshycoPortrait = "Aruni is quick on her feet, both mentally and physically. She rarely hesitates, and her judgement is flawless under the most trying circumstances. Her reaction speed, combined with her expertise in firearms and martial arts, means that she is a versatile and deadly combatant. Her fitness regimen – taken up following years of physical and psychological recovery – is intense, but it enables her to maintain peak performance. [...]\nAruni’s affiliation with Nighthaven appears to be one of convenience. Nighthaven pays well and provides her with access to cutting edge prosthetic technology. While she uses some of the money she earns to support herself, she’s also a quiet philanthropist with a very frugal lifestyle. She donates time and money to charities that focus on the disposal of unexploded ordnance along the Thailand-Cambodia border and medical treatment for victims. One of Aruni’s closest companions is Hero, a giant pouched rat trained in demolitions disposal. Though not stated outright, Hero appears to be her emotional support animal. [...]\nWhen time is in short supply, Aruni has a penchant to bend the rules in favor of expedience – an understandable impulse, especially in cases where lives are on the line, but it isn’t always acceptable to her superiors. Though she was a brilliant police detective, her tendency to prefer convenience over procedure led to a number of minor infractions. [...]\nWhile she’s done the majority of her professional work in Thailand, Aruni is an accomplished world traveler. Her wanderlust has taken her to other parts of Southeast Asia, as well as Central and South America. [...] She and other Specialists – namely Emmanuelle “Twitch” Pichon and Sanaa “Nomad” El Maktoub – have traveled together, providing both companionship and security when visiting destabilized regions. [...]\nShe uses photography – a skill she developed as a private detective in Bangkok – as a way to raise global awareness of the vast minefields left over from prior wars. These personal photographs tend to focus on the victims of conflict, especially those maimed by unexploded ordnance. Ultimately, these images allow her to give herself what so few of us think we truly deserve – compassion.\n-- Dr. Harishva \"Harry\" Pandey, Director of Rainbow\"",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 2,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "AruniLoadout").FirstOrDefault(),
                        AbilityName = "SURYA GATE",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Surya-Gate.webp",
                        AbilityTLDR = "Once in place, the gate projects a laser array capable of detecting anyone moving through it. When an intruder is detected, energy output to the laser increases, causing second- and third-degree burns. We spent nearly an hour tossing everything from wads of paper to pieces of fruit through until we found a setting that maximizes damage while limiting energy consumption.",
                        AbilityDemoLink = "https://youtu.be/7LLwRc0EUp8"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
