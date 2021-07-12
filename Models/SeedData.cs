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
                    },
                    new Operator
                    {
                        Name = "Lesion",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/lesionPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/lesion.png",
                        Role = "Anchor, Crowd Control, Intel Gatherer, Roam, Trap",
                        Origin = "S.D.U",
                        Biography = "“Make no excuses for who you are. Only the weak-minded will demand you make yourself smaller.”\nBorn and raised in Tseung Kwan O (Junk Bay), Liu’s early years were spent working alongside his father in the shipyards, stripping obsolete tankers for raw materials and parts. Growing up surrounded by hazardous materials and seeing their long-term effects on his fellow workers left Liu with an abiding respect for toxins and their effect on the human body. Initially seeking additional income, he volunteered for mine clearing duties in Yunnan and Guangxi provinces where his abilities and bravery caught the attention of key personnel within the Hong Kong Police Department. Liu then joined the Explosive Ordnance Disposal Bureau (EOD), giving him the opportunity to continue his chemistry and forensics-based education along with intense on-site training. Liu’s expertise with chemical, biological, radiological, and nuclear threats made him a clear first pick during the formation of Rainbow’s CBRN unit. Liu continues to volunteer for mine clearing duty in his spare time.",
                        PshycoPortrait = "Specialist Liu “Lesion” Tze Long’s teammates have a great deal of respect for him, despite the fact that he can often drop off the radar due to his low-key style. Liu doesn’t mind that he’s overlooked; in fact, when I suggested this to him it prompted a smile. While on an operation, Liu is intense and focused, and thinks quickly on his feet. In his downtime he is soft-spoken with a wonderful dry wit.\nHis family’s poverty encouraged him to be philosophical about his childhood. Even now he prefers to keep life simple by spending his money and time on things that have purpose. Liu told me he isn’t a person who rails against things beyond his control, and I know from observation that he isn’t someone who counts his scars. […]\nHis childhood, frankly, sounds horrific. His health was at risk from toxic materials, not to mention the physical danger of ripping apart tonnes of steel. And yet Liu remembers his past fondly, regarding the bad moments as something he was lucky enough to survive. I wondered if his optimism was a survival mechanism to weather horrifying circumstances, but Liu was eager to put me at ease. It wasn’t all bad, he said. He described how he and his father would admire the sunrise dancing across the water and take long lunch breaks to go fishing. […]\nLiu continues to live close to where he grew up. His connection to the location is more than nostalgia. There’s a sense of satisfaction in knowing what it used to be and how time has affected it. Liu says both he and Junk Bay have changed for the better, and that the future can always be shaped into something good.\nAs he did at the start of his career, Liu still volunteers in underprivileged areas. His expertise has contributed to the clearing of tens of thousands of mines and unexploded ordnance. In particular, he’s been consulting the tech experts within Rainbow as he and operators Olivier “Lion” Flament and Lera “Finka” Melnikova look to incorporate state-of-the-art solutions into their CBRN threat unit.\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 1,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "LesionLoadout").FirstOrDefault(),
                        AbilityName = "GU MINES",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Gu-mines.webp",
                        AbilityTLDR = "Gu mines were inspired by the sharp punji sticks used during the Vietnam War. Rubbed with toxic plants or feces, the stakes served to slow down enemy troops by causing severe infections in their camp. Similarly, Gu mines inject a toxin that injure your opponent and limit their speed.",
                        AbilityDemoLink = "https://www.youtube.com/watch?v=6Q-sSKQGJdA"
                    },
                    new Operator
                    {
                        Name = "Ela",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/elaPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/ela.png",
                        Role = "Crowd Control, Roam, Trap",
                        Origin = "G.R.O.M",
                        Biography = "“Together, we can shake the very stars from the sky.”\nElżbieta Bosak is the youngest daughter of respected Jan Bosak, former commander of the Polish Special Operations Forces unit GROM. Like her sister, Zofia, Ela excelled in the grueling training imposed upon them by their father. She attended officers’ school but couldn’t reconcile military life with her need for independence and left to study Fine Arts in Berlin. Her reputation for using military paraphernalia in her art attracted the owner of a small private security company, who offered her a job. She was valued in the private sector for her expertise in survivalist tactics and unique adaptive style during protective detail and intelligence gathering, until her father’s death convinced her to return to Poland and join GROM. Ela is a reliable team player with leadership potential, even if her distrust of authority continues to be a point of contention. Her successful collaboration with SEAL prompted her invitation to join Rainbow.",
                        PshycoPortrait = "We civilians can understand Specialist Elżbieta “Ela” Bosak’s independent nature more than some starch-collared military commander might. Of course, following orders is expected of those within the rank-and-file, and for someone so quick to buck against authority she also expresses a deep respect for the military and her role within it. It’s her autonomy that rubs traditionalists the wrong way, and perhaps her anger. Even at our first meeting, I detected her resolve. She is fighting against something, but it may not be authority – at least not entirely. […]\nI won’t dismiss the concerns of commanding officers who mention that Bosak can be impulsive, but I would urge them instead to appreciate her creative resilience. Anyone who has worked with artists can attest to this quality. It manifests in the field in the protection of her team and her high number of successful operations. Her impulsiveness – her adaptability – is the very quality that causes her to excel. […]\nBoth Ela and her sister, Zofia, carry the deep impression of their father’s influence. Ela is more inclined to accept that her father, though exceptional, wasn’t perfect. In reviewing Commander Jan Bosak’s file, I saw a proud, insightful man. That’s the key. Ela is finely tuned to the patterns and behaviors around her and when she seems defiant it’s because she’s frustrated with those who lack this “vision.” Joining Rainbow, and working with other elite operators, has somewhat tempered this frustration as she no longer feels constrained by the attitudes of those around her. […]\nEla’s defiance extends into her personal life. She isn’t interested in self-improvement, she told me. She was surprised when I said I know about her “volunteer work.” She roams the streets late at night, with food and blankets to hand out, or even just a cigarette. Then she listens. Her conversations with strangers offer fresh perspectives. She stockpiles them, to add to her insight and therefore her skills, but also as fuel for her work. The status quo isn’t what she wants it to be, but that won’t stop her from trying to kick it into shape.\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 1,
                        Speed = 3,
                        Difficulty = 1,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "ElaLoadout").FirstOrDefault(),
                        AbilityName = "GRZMOT MINE",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Grzmot-Mine.webp",
                        AbilityTLDR = "Inspired by the 1939 anti-tank Polish grenades used by the iconic Cichociemny during WWII, the sticky Grzmot mines can be anchored on surfaces, impairing hearing and causing a dizzying effect. These concussion mines are triggered upon proximity, affecting anyone within its radius.",
                        AbilityDemoLink = "https://www.youtube.com/watch?v=6Q-sSKQGJdA"
                    },
                    new Operator
                    {
                        Name = "Echo",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/echoPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/echo.png",
                        Role = "Anchor, Crowd Control, Intel Gatherer, Secure",
                        Origin = "S.A.T.",
                        Biography = "“Don’t ask me what I’m doing on my phone. You don’t want to know.”\nEnatsu grew up in Suginami, outside of Tokyo. Fascinated with robotics from an early age, he designed and programmed both terrestrial and flying drones and went on to win numerous competitions. After studying Electrical and Electronic Engineering at Tokyo Metropolitan University, Enatsu was encouraged to join the National Police Agency Security Bureau where he worked tirelessly in their research and development lab. Trained in counter-terrorism and intelligence gathering, Enatsu began designing specific tech that would better aid the Bureau. Joint training after the Nagoya hostage crisis prompted Enatsu to transfer to the Aichi Prefectural Police Department Special Unit where his tenacious focus enabled him to find creative solutions and alternate strategies. He eventually returned to Tokyo, where his exceptional intel gathering techniques as well as his quick and unpredictable methodology caught the attention of Rainbow.",
                        PshycoPortrait = "To say that Specialist Masaru “Echo” Enatsu’s file has a few flags regarding his conduct is an understatement. Prior to our first session together I had met with every other member of Rainbow – some more than once. So when the conversation began with Enatsu admitting he’d been avoiding me, I knew we were going to get along.\nOften, I would rather not read a file first, to give someone a chance to tell me who they are in their own words. In this case it was important that I know what people think, because Enatsu was braced for my reaction. […]\nI gather he and his family aren’t close. He joked that a calculator has more emotional range than his parents. This upbringing has made him resistant to working in groups, because a friendly, mutually beneficial dynamic isn’t one he’s familiar with. It’s my hope his time with Rainbow will help, but his desire to explore the “AI” of his fellow operators by pushing their buttons is something that may need to be handled from within the group. […]\nEnatsu’s tactics have been described as tricky and unpredictable. This can work as a strong team strategy but it demands communication. […] I’d also encourage the team to think of how best to utilize Enatsu’s potential. Some operators assume there will be issues with him before they even begin, which leads to predictable results. […]\nSpecialists Yumiko “Hibana” Imagawa and Grace “Dokkaebi” Nam work with Enatsu on R&D quite often, actually. I’ve also noticed that he’s developed a rapport with Specialist Taina “Caveira” Pereira. I suspect he appreciates Pereira’s candor, since it ties into his own assumption that people who are offended simply don’t “get the joke.” […]\nEnatsu frustrates easily. He has few outside interests, and consequently thinks only about improving his operational efficiency. It’s important that he recognize that everyone needs diversions – those in high-stress jobs even more so. It isn’t a sign of weakness to “switch off” every now and again, even if he has been conditioned to believe that a restful mind indicates a lack of intelligence.\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 3,
                        Speed = 1,
                        Difficulty = 3,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "EchoLoadout").FirstOrDefault(),
                        AbilityName = "YOKAI",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Yokai.webp",
                        AbilityTLDR = "Equipped with an acoustic hailing device, this signature drone can fire ultrasonic bursts that disorient all targets in a given perimeter. Yokai also transmits a video feed to Echo, who keeps his immediate perimeter secure. Embrace the power of technology and embody a turret Defender who can both hold up the siege and support roamers.",
                        AbilityDemoLink = "https://www.youtube.com/watch?v=8fbdcL04xQA"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
