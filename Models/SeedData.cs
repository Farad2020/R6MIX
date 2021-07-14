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
                if (context.Operator.Any())
                {
                    return;   // DB has been seeded
                }

                //foreach (var entity in context.Operator)
                //    context.Operator.Remove(entity);

                context.Operator.AddRange(
                    //Defenders
                    new Operator
                    {
                        Name = "Warden",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/wardenPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/warden.png",
                        Role = "Anchor, Intel Denier",
                        Origin = "Secret Service",
                        Biography = "\"I'm never unprepared.\" \n\nCollinn McKinley enrolled in the Marine Corps at 18 and earned several commendations in his service jacket for his aggressive quick-thinking, achieving Master Sergeant despite a few minor infractions on his record. After his third tour, he left the Marines and entered the Secret Service in close-protection detail. McKinley’s agility was instrumental in saving Secretary of State Baldwin’s life when insurgents attacked the U.S. diplomatic junket. Baldwin later went on to win the U.S. Presidential and requested McKinley be assigned to the Presidential Protective Division. McKinley has spent over a decade in Washington, protecting important political figures. He is the foremost expert in close protection detail, and with President Baldwin finishing his second term, McKinley has received high endorsements for his transition into Rainbow.",
                        PshycoPortrait = "I’ve learned to read between the lines, and when it comes to Specialist Collinn \"Warden\" McKinley, that’s where the real story lies. His role as protector came easily to him between butting heads with his strict, hardworking father and defending his brothers at school, but it became more deeply engrained during his three tours with the Marines.\n\nMcKinley’s service with the Secret Service reads like a Washington gossip column/spy novel. During the attack on then Secretary-of-State Baldwin, the attackers used flashbangs, smoke grenades, and heavy suppressing fire to separate the protection detail. McKinley realized all their evacuation routes had been compromised and evacuated Baldwin alone. The incident clarified the reason behind McKinley’s special glasses, but it’s also become indicative of his modus operandi… his off-the-cuff attitude. He’s never been wrong and I fear he’ll rely on instinct until it finally fails him.\n\nHis access to the inner circle through the Office of the President made him the go-to in handling delicate situations. He’s clever enough to lead people on the right track without implicating himself and I suspect he knows where a few bodies are buried. McKinley has amassed quite the war chest of political favors and a reputation as a lady’s man. President Baldwin once told me that McKinley’s dalliances eclipsed that of some Presidential administrations. The First Lady was displeased with that joke.\n\nHe knows how to manipulate; he deepens his Kentucky drawl when dealing with Republican senators, and plays the Southern gentleman around women. I was amused, watching him try to play to my personality… but I play the game too.\n\nMcKinley adores his teams and he works well with others, but his connection to the Oval Office has instilled him with a sense of invulnerability. McKinley has made many enemies among politicians, businessmen, and Lobbyists; he’s a walking encyclopedia of their sins, and President Baldwin won’t be around to protect him anymore.\n\nHe is the sort of non-traditional approach we need to keep the military and law enforcement more agile and surgical, someone who understands coordination on a large scale. Unfortunately, that means I owe President Baldwin a 25-year old single malt Scotch for recommending McKinley; he’s insufferable when he’s right.\n\n-- Dr. Harishva Pandey",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 2,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "WardenLoadout").FirstOrDefault(),
                        AbilityName = "GLANCE SMART GLASSES",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Glance-Smart-Glasses.webp",
                        AbilityTLDR = "The Glance serves a function that was almost non-existent on the Defending team. With it active, Warden can see through smoke and turn around what could be a low-intel situation. Activating his Smart Glasses can also prevent Warden from being blinded by flash effects, or cleanse an existing flash blindness, salvaging an otherwise dangerous few seconds. However, the Glance’s thermal vision only works as long as Warden stays immobile; otherwise, he is affected by smoke the same as everyone else. The Glance is a triggered effect, which must be restored through a cooldown after use.",
                        AbilityDemoLink = "qpZBD30L7fo"
                    },
                    new Operator
                    {
                        Name = "Aruni",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/aruniPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/aruni.png",
                        Role = "Secure, Intel Gatherer, Anchor",
                        Origin = "NIGHTHAVEN",
                        Biography = "“In every conflict, it’s the children who are made to suffer, even after the fighting has stopped.”\n\nAs a private detective, her discovery of a bomb plot in Bangkok brought Aruni to the attention of the Royal Thai Police (RTP). Her knack for connecting the dots between seemingly-unrelated incidents earned her grudging respect from Thailand’s male-dominated law enforcement agencies, as well as hostility from numerous criminal syndicates.\n\nThe RTP offered Aruni a Detective position with the Crime Suppression Division, where she dismantled a human trafficking ring and foiled no fewer than four bomb plots. Her ability to track and connect diverse shipments of explosive materials was lauded by her superiors. Unfortunately, Aruni’s police career ended when she was nearly killed during an operation in Bangkok.\nFollowing her recovery, Aruni was approached by Jaimini “Kali” Shah. Kali’s access to cutting-edge prosthetics was likely a factor in Aruni’s decision to join Nighthaven.",
                        PshycoPortrait = "Aruni is quick on her feet, both mentally and physically. She rarely hesitates, and her judgement is flawless under the most trying circumstances. Her reaction speed, combined with her expertise in firearms and martial arts, means that she is a versatile and deadly combatant. Her fitness regimen – taken up following years of physical and psychological recovery – is intense, but it enables her to maintain peak performance. [...]\n\nAruni’s affiliation with Nighthaven appears to be one of convenience. Nighthaven pays well and provides her with access to cutting edge prosthetic technology. While she uses some of the money she earns to support herself, she’s also a quiet philanthropist with a very frugal lifestyle. She donates time and money to charities that focus on the disposal of unexploded ordnance along the Thailand-Cambodia border and medical treatment for victims. One of Aruni’s closest companions is Hero, a giant pouched rat trained in demolitions disposal. Though not stated outright, Hero appears to be her emotional support animal. [...]\n\nWhen time is in short supply, Aruni has a penchant to bend the rules in favor of expedience – an understandable impulse, especially in cases where lives are on the line, but it isn’t always acceptable to her superiors. Though she was a brilliant police detective, her tendency to prefer convenience over procedure led to a number of minor infractions. [...]\n\nWhile she’s done the majority of her professional work in Thailand, Aruni is an accomplished world traveler. Her wanderlust has taken her to other parts of Southeast Asia, as well as Central and South America. [...] She and other Specialists – namely Emmanuelle “Twitch” Pichon and Sanaa “Nomad” El Maktoub – have traveled together, providing both companionship and security when visiting destabilized regions. [...]\n\nShe uses photography – a skill she developed as a private detective in Bangkok – as a way to raise global awareness of the vast minefields left over from prior wars. These personal photographs tend to focus on the victims of conflict, especially those maimed by unexploded ordnance. Ultimately, these images allow her to give herself what so few of us think we truly deserve – compassion.\n\n-- Dr. Harishva \"Harry\" Pandey, Director of Rainbow\"",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 2,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "AruniLoadout").FirstOrDefault(),
                        AbilityName = "SURYA GATE",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Surya-Gate.webp",
                        AbilityTLDR = "Once in place, the gate projects a laser array capable of detecting anyone moving through it. When an intruder is detected, energy output to the laser increases, causing second- and third-degree burns. We spent nearly an hour tossing everything from wads of paper to pieces of fruit through until we found a setting that maximizes damage while limiting energy consumption.",
                        AbilityDemoLink = "7LLwRc0EUp8"
                    },
                    new Operator
                    {
                        Name = "Lesion",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/lesionPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/lesion.png",
                        Role = "Anchor, Crowd Control, Intel Gatherer, Roam, Trap",
                        Origin = "S.D.U",
                        Biography = "“Make no excuses for who you are. Only the weak-minded will demand you make yourself smaller.”\n\nBorn and raised in Tseung Kwan O (Junk Bay), Liu’s early years were spent working alongside his father in the shipyards, stripping obsolete tankers for raw materials and parts. Growing up surrounded by hazardous materials and seeing their long-term effects on his fellow workers left Liu with an abiding respect for toxins and their effect on the human body. Initially seeking additional income, he volunteered for mine clearing duties in Yunnan and Guangxi provinces where his abilities and bravery caught the attention of key personnel within the Hong Kong Police Department. Liu then joined the Explosive Ordnance Disposal Bureau (EOD), giving him the opportunity to continue his chemistry and forensics-based education along with intense on-site training. Liu’s expertise with chemical, biological, radiological, and nuclear threats made him a clear first pick during the formation of Rainbow’s CBRN unit. Liu continues to volunteer for mine clearing duty in his spare time.",
                        PshycoPortrait = "Specialist Liu “Lesion” Tze Long’s teammates have a great deal of respect for him, despite the fact that he can often drop off the radar due to his low-key style. Liu doesn’t mind that he’s overlooked; in fact, when I suggested this to him it prompted a smile. While on an operation, Liu is intense and focused, and thinks quickly on his feet. In his downtime he is soft-spoken with a wonderful dry wit.\n\nHis family’s poverty encouraged him to be philosophical about his childhood. Even now he prefers to keep life simple by spending his money and time on things that have purpose. Liu told me he isn’t a person who rails against things beyond his control, and I know from observation that he isn’t someone who counts his scars. […]\n\nHis childhood, frankly, sounds horrific. His health was at risk from toxic materials, not to mention the physical danger of ripping apart tonnes of steel. And yet Liu remembers his past fondly, regarding the bad moments as something he was lucky enough to survive. I wondered if his optimism was a survival mechanism to weather horrifying circumstances, but Liu was eager to put me at ease. It wasn’t all bad, he said. He described how he and his father would admire the sunrise dancing across the water and take long lunch breaks to go fishing. […]\n\nLiu continues to live close to where he grew up. His connection to the location is more than nostalgia. There’s a sense of satisfaction in knowing what it used to be and how time has affected it. Liu says both he and Junk Bay have changed for the better, and that the future can always be shaped into something good.\n\nAs he did at the start of his career, Liu still volunteers in underprivileged areas. His expertise has contributed to the clearing of tens of thousands of mines and unexploded ordnance. In particular, he’s been consulting the tech experts within Rainbow as he and operators Olivier “Lion” Flament and Lera “Finka” Melnikova look to incorporate state-of-the-art solutions into their CBRN threat unit.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 1,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "LesionLoadout").FirstOrDefault(),
                        AbilityName = "GU MINES",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Gu-mines.webp",
                        AbilityTLDR = "Gu mines were inspired by the sharp punji sticks used during the Vietnam War. Rubbed with toxic plants or feces, the stakes served to slow down enemy troops by causing severe infections in their camp. Similarly, Gu mines inject a toxin that injure your opponent and limit their speed.",
                        AbilityDemoLink = "6Q-sSKQGJdA"
                    },
                    new Operator
                    {
                        Name = "Ela",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/elaPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/ela.png",
                        Role = "Crowd Control, Roam, Trap",
                        Origin = "G.R.O.M",
                        Biography = "“Together, we can shake the very stars from the sky.”\n\nElżbieta Bosak is the youngest daughter of respected Jan Bosak, former commander of the Polish Special Operations Forces unit GROM. Like her sister, Zofia, Ela excelled in the grueling training imposed upon them by their father. She attended officers’ school but couldn’t reconcile military life with her need for independence and left to study Fine Arts in Berlin. Her reputation for using military paraphernalia in her art attracted the owner of a small private security company, who offered her a job. She was valued in the private sector for her expertise in survivalist tactics and unique adaptive style during protective detail and intelligence gathering, until her father’s death convinced her to return to Poland and join GROM. Ela is a reliable team player with leadership potential, even if her distrust of authority continues to be a point of contention. Her successful collaboration with SEAL prompted her invitation to join Rainbow.",
                        PshycoPortrait = "We civilians can understand Specialist Elżbieta “Ela” Bosak’s independent nature more than some starch-collared military commander might. Of course, following orders is expected of those within the rank-and-file, and for someone so quick to buck against authority she also expresses a deep respect for the military and her role within it. It’s her autonomy that rubs traditionalists the wrong way, and perhaps her anger. Even at our first meeting, I detected her resolve. She is fighting against something, but it may not be authority – at least not entirely. […]\n\nI won’t dismiss the concerns of commanding officers who mention that Bosak can be impulsive, but I would urge them instead to appreciate her creative resilience. Anyone who has worked with artists can attest to this quality. It manifests in the field in the protection of her team and her high number of successful operations. Her impulsiveness – her adaptability – is the very quality that causes her to excel. […]\n\nBoth Ela and her sister, Zofia, carry the deep impression of their father’s influence. Ela is more inclined to accept that her father, though exceptional, wasn’t perfect. In reviewing Commander Jan Bosak’s file, I saw a proud, insightful man. That’s the key. Ela is finely tuned to the patterns and behaviors around her and when she seems defiant it’s because she’s frustrated with those who lack this “vision.” Joining Rainbow, and working with other elite operators, has somewhat tempered this frustration as she no longer feels constrained by the attitudes of those around her. […]\n\nEla’s defiance extends into her personal life. She isn’t interested in self-improvement, she told me. She was surprised when I said I know about her “volunteer work.” She roams the streets late at night, with food and blankets to hand out, or even just a cigarette. Then she listens. Her conversations with strangers offer fresh perspectives. She stockpiles them, to add to her insight and therefore her skills, but also as fuel for her work. The status quo isn’t what she wants it to be, but that won’t stop her from trying to kick it into shape.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 1,
                        Speed = 3,
                        Difficulty = 1,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "ElaLoadout").FirstOrDefault(),
                        AbilityName = "GRZMOT MINE",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Grzmot-Mine.webp",
                        AbilityTLDR = "Inspired by the 1939 anti-tank Polish grenades used by the iconic Cichociemny during WWII, the sticky Grzmot mines can be anchored on surfaces, impairing hearing and causing a dizzying effect. These concussion mines are triggered upon proximity, affecting anyone within its radius.",
                        AbilityDemoLink = "6Q-sSKQGJdA"
                    },
                    new Operator
                    {
                        Name = "Echo",
                        OpImgLink = "/media/defenderMedia/defenderPortraits/echoPortrait.png",
                        OpIconLink = "/media/defenderMedia/defenderIcons/echo.png",
                        Role = "Anchor, Crowd Control, Intel Gatherer, Secure",
                        Origin = "S.A.T.",
                        Biography = "“Don’t ask me what I’m doing on my phone. You don’t want to know.”\n\nEnatsu grew up in Suginami, outside of Tokyo. Fascinated with robotics from an early age, he designed and programmed both terrestrial and flying drones and went on to win numerous competitions. After studying Electrical and Electronic Engineering at Tokyo Metropolitan University, Enatsu was encouraged to join the National Police Agency Security Bureau where he worked tirelessly in their research and development lab. Trained in counter-terrorism and intelligence gathering, Enatsu began designing specific tech that would better aid the Bureau. Joint training after the Nagoya hostage crisis prompted Enatsu to transfer to the Aichi Prefectural Police Department Special Unit where his tenacious focus enabled him to find creative solutions and alternate strategies. He eventually returned to Tokyo, where his exceptional intel gathering techniques as well as his quick and unpredictable methodology caught the attention of Rainbow.",
                        PshycoPortrait = "To say that Specialist Masaru “Echo” Enatsu’s file has a few flags regarding his conduct is an understatement. Prior to our first session together I had met with every other member of Rainbow – some more than once. So when the conversation began with Enatsu admitting he’d been avoiding me, I knew we were going to get along.\n\nOften, I would rather not read a file first, to give someone a chance to tell me who they are in their own words. In this case it was important that I know what people think, because Enatsu was braced for my reaction. […]\n\nI gather he and his family aren’t close. He joked that a calculator has more emotional range than his parents. This upbringing has made him resistant to working in groups, because a friendly, mutually beneficial dynamic isn’t one he’s familiar with. It’s my hope his time with Rainbow will help, but his desire to explore the “AI” of his fellow operators by pushing their buttons is something that may need to be handled from within the group. […]\n\nEnatsu’s tactics have been described as tricky and unpredictable. This can work as a strong team strategy but it demands communication. […] I’d also encourage the team to think of how best to utilize Enatsu’s potential. Some operators assume there will be issues with him before they even begin, which leads to predictable results. […]\n\nSpecialists Yumiko “Hibana” Imagawa and Grace “Dokkaebi” Nam work with Enatsu on R&D quite often, actually. I’ve also noticed that he’s developed a rapport with Specialist Taina “Caveira” Pereira. I suspect he appreciates Pereira’s candor, since it ties into his own assumption that people who are offended simply don’t “get the joke.” […]\n\nEnatsu frustrates easily. He has few outside interests, and consequently thinks only about improving his operational efficiency. It’s important that he recognize that everyone needs diversions – those in high-stress jobs even more so. It isn’t a sign of weakness to “switch off” every now and again, even if he has been conditioned to believe that a restful mind indicates a lack of intelligence.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 3,
                        Speed = 1,
                        Difficulty = 3,
                        OpSide = context.Side.Where(s => s.Name == "Defender").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "EchoLoadout").FirstOrDefault(),
                        AbilityName = "YOKAI",
                        AbilityIcon = "/media/defenderMedia/defenderAbilityIcons/Yokai.webp",
                        AbilityTLDR = "Equipped with an acoustic hailing device, this signature drone can fire ultrasonic bursts that disorient all targets in a given perimeter. Yokai also transmits a video feed to Echo, who keeps his immediate perimeter secure. Embrace the power of technology and embody a turret Defender who can both hold up the siege and support roamers.",
                        AbilityDemoLink = "8fbdcL04xQA"
                    },

                    //Attacker

                    new Operator
                    {
                        Name = "Ash",
                        OpImgLink = "/media/attackerMedia/attackerPortraits/ashPortrait.png",
                        OpIconLink = "/media/attackerMedia/attackerIcons/ash.png",
                        Role = "Disable, Flank, Front Line, Soft Breach",
                        Origin = "SWAT",
                        Biography = "“You can never truly understand a conflict until you’ve been on both sides.”\n\nCohen’s mother is a renowned Jewish political activist and professor while her Palestinian father is a professor of Middle Eastern Studies. Cohen was raised in Israel, excelling in Mathematics and Physics. She earned a degree in Structural Engineering at Tel Aviv University and spent a few semesters at Boston University.\n\nCohen then enlisted in the Israeli Defense Forces (IDF). After undergoing the rigorous twenty-two month training for the elite Air Force unit, Shaldag, she served five years. Skilled in ground and airborne operations, all-weather and all-terrain navigation and reconnaissance, she was invaluable in Operation Orchard. Moving to the US to work with FBI SWAT, Cohen applied her degree in Engineering and gift in structural resistance to develop advanced demolition tactics and equipment. Along with Hebrew, Cohen is fluent in Arabic, English, French and Greek.",
                        PshycoPortrait = "I had several meetings with Specialist Eliza “Ash” Cohen before I gave up on convincing her to not see me as a commanding officer. She asked so many probing questions, it was starting to feel as though she were analyzing me. […]\n\nCohen isn’t interested in discussing her childhood. There’s resentment toward a judgmental grandmother, but no lasting trauma. Military service acted as an escape from family tensions and appealed to her ordered and focused personality. Cohen added that she appreciates high-risk, high-reward scenarios, but didn’t elaborate on what level of personal risk is acceptable.\n\nHer identity is intertwined with her military training and operations. Extracting anything personal from the tangle is difficult. Cohen is cautious and doesn’t cultivate many close relationships. Her bond with Specialist Miles “Castle” Campbell is therefore important to her – and I would say to the team as well. It’s certainly a good pairing. Campbell’s amenable personality enables Cohen to step out of her comfort zone without feeling self-conscious or judged. […]\n\nCohen uses other people’s assessments to describe herself: She told me that Specialists Dominic “Bandit” Brunsmeier and James “Smoke” Porter tell her she’s “too serious,” while others describe her as “intense,” and that she enjoys being proven right. So I asked if she thought those descriptions were accurate. She told me that she only cares about whether the other operators respect her. I’m confident they do. […]\n\nOn operations, Cohen is exemplary: She thinks fast, and her aggressive style almost always puts her at an advantage. During debriefs, however, I’ve noticed a different kind of focus. The residual stress of combat causes her to dwell on every misstep, perceived or real. Self-evaluation is understandable from someone so highly skilled, but it also has an effect on her team. It’s important to encourage her to process the events as a joint effort and not simply assume the critique alone. Cohen – like all operators – knows there will be situations she can’t prepare for. And yet, she alone allows the stress of the unknown to eat at her. This will need to be addressed.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 1,
                        Speed = 3,
                        Difficulty = 2,
                        OpSide = context.Side.Where(s => s.Name == "Attacker").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "AshLoadout").FirstOrDefault(),
                        AbilityName = "BREACHING ROUNDS",
                        AbilityIcon = "/media/attackerMedia/attackerAbilityIcons/Breaching-Rounds.webp",
                        AbilityTLDR = "Ash is a fast-paced front liner; capable of breaching, flanking and dividing the Defender's attention in seconds.\n\nAsh is capable of ranged soft breaching thanks to her modified M120 CREM Breaching Rounds.",
                        AbilityDemoLink = "aA4X-wsKskA"
                    },
                    new Operator
                    {
                        Name = "Thermite",
                        OpImgLink = "/media/attackerMedia/attackerPortraits/thermitePortrait.png",
                        OpIconLink = "/media/attackerMedia/attackerIcons/thermite.png",
                        Role = "Back Line,Hard Breach",
                        Origin = "SWAT",
                        Biography = "“You see a wall, I see an opportunity.”\n\nTrace joined the Corps straight out of high school, making him a fourth-generation Marine. Following his first tour of Iraq, he obtained enough experience to volunteer as an explosive ordnance disposal technician. After his second tour of Iraq, Trace returned to the U.S., enrolled in university, and earned a Bachelor of Science in Chemistry. He brought his experience and skills to the FBI, where he spent a number of years as a field agent within the Hazardous Materials Response Unit. Seeking more dynamic environments, Trace transferred into FBI SWAT, where he excelled at developing new barricade protocols. He then earned a spot in Rainbow where he’s shown further interest in research and development on gadget upgrades. Trace’s hometown of Plano has a major concentration of Chinese Americans, and as such Trace has conversational level of Mandarin.",
                        PshycoPortrait = "For someone so disciplined and orderly, Specialist Jordan “Thermite” Trace likes to surprise. He can be a practical joker and he’s always ready with a smart aleck comment. Beneath the surface, however, the recent loss of his sister to cancer, and the death of his mother a few years prior, have made it difficult for him to channel his thoughts and energy with the focus to which he is accustomed. […] I am concerned that he uses humor to avoid his grief. It’s important he understands that some coping mechanisms can delay the healing process. There are resources that can help him, and I will continue to offer them when and where I may. […]\n\nTrace demonstrates strong tactical leadership, but can also plow ahead without consensus. I don’t believe there’s any lasting friction with other team members. He’s well-liked by the others and has a solid working relationship with Specialists Yumiko “Hibana” Imagawa, Mike “Thatcher” Baker, and Emmanuelle “Twitch” Pichon. He can be quite the social-butterfly in his downtime. […]\n\nA few things to work on: Trace has excellent communication, when he chooses to use it. He has good strategies but sometimes tends to “lock in.” I know that he’s capable of being a more agile thinker, so I’ve given him some tips on how to recognize when he’s becoming too… bullheaded. […]\n\nThere’s a lot going on behind his smile. I’d like him to find a way to regulate himself, to find balance for his work and private life. Trace doesn’t show obvious stressors, opting instead to channel any anxious energy into something positive such as the R&D lab. It has been difficult to convince him that he needs a break from his role and identity as an operator. Shifting his attention to other intense tasks isn’t a solution. […] I’ve given him some mental relaxation exercises that don’t demand considerable time, but can be tackled throughout the day. Imagawa, in particular, can be a good influence on him since she regularly practices mindfulness techniques to focus and relax. I hope he will take her advice to heart.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 1,
                        OpSide = context.Side.Where(s => s.Name == "Attacker").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "ThermiteLoadout").FirstOrDefault(),
                        AbilityName = "EXOTHERMIC CHARGE",
                        AbilityIcon = "/media/attackerMedia/attackerAbilityIcons/Exothermic-Charge.webp",
                        AbilityTLDR = "Thermite is an important backline support for an attacking team. As one of the only hard-breachers in the game, losing Thermite early in the round will hinder your team significantly. Playing Thermite requires patience, leadership and strong communication with your team.",
                        AbilityDemoLink = "ewd81XAupgk"
                    },
                    new Operator {
                        Name = "Zero",
                        OpImgLink = "/media/attackerMedia/attackerPortraits/zeroPortrait.png",
                        OpIconLink = "/media/attackerMedia/attackerIcons/zero.png",
                        Role = "Intel Denier,Intel Gatherer",
                        Origin = "ROS",
                        Biography = "“Prepare, execute, vanish.”\n\nThough the CIA and Third Echelon have classified the majority of Fisher’s childhood it is known he was born in the Baltimore suburb of Towson, Maryland, where he was raised by his paternal grandmother, Sarah. He was enrolled in a Military Boarding School where he learned to focus his energy, hone his skills, and to either follow orders or be sure to hide the evidence.\n\nFrom school Fisher enrolled directly in the United States Naval Academy where he majored in Political Science and later went on to pursue SEALs Training. While serving in the Persian Gulf, Bolivia, Columbia, Senegal, and Kosovo, Fisher became known for his ability to complete the mission, regardless of personal cost. After being awarded a Defense Distinguished Service Medal, Fisher spent time as an instructor at Little Creek Naval Base, Virginia.\n\nHe was recruited to the CIA, where he [REDACTED].",
                        PshycoPortrait = "Although these are my first interactions and observations of Specialist Samuel Leo “Zero” Fisher, I feel that I’m finally getting a glimpse of the man behind the legend. He doesn’t brag about what he’s done or what he can do, but you can see his training in the way he moves and the critical assessment with which he evaluates his surroundings. If he were to read my evaluation, I’m sure he’d agree. […]\n\nIt’s hard to pry details from the former Echelon agent. He is focused , to the point, and makes it clear when he’s done with a subject. His mandate was never to seek out conflict, but to perform damage control before there was any evidence of a disaster. Fisher’s skills and temperament ensure that he keeps a clear head under pressure and is always prepared, regardless of circumstance. I’m interested to see if he has a leveling influence on some of our more hotheaded specialists such as Evans and Brunsmeier.\n\nThough his sarcasm can seem abrasive to those who aren’t familiar with him – and maybe even to those who are – it hides a deep thoughtfulness and attention to detail. He can see right into the heart of an issue, or person – I look forward to his assessment and his suggestions for the improvements we can make to our training program. […]\n\nHe doesn’t want to talk about his daughter, but I feel that’s more of a warning than an indication of any residual conflict between them. [REDACTED]\n\n(Comment_S. Fisher: Great observation, also correct.)\n\nFisher is very much a solo operator, though he possesses a sense of duty to his colleagues and teammates and shows his affection through action. I’m hoping to draw him out of his shell and show him the benefits of working with the R6 Program. Based on his background as an instructor I feel he’ll appreciate more than the resources we can offer him, but also gain some satisfaction in the influence he’ll have on the R6 Program, and his teammates.\n\n(Comment_S. Fisher: Is one of the benefits coffee, because I’m running low.)\n\n-- Dr. Harishva \"Harry\" Pandey, Director of Rainbow",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 3,
                        OpSide = context.Side.Where(s => s.Name == "Attacker").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "ZeroLoadout").FirstOrDefault(),
                        AbilityName = "ARGUS LAUNCHER",
                        AbilityIcon = "/media/attackerMedia/attackerAbilityIcons/Argus-Launcher.webp",
                        AbilityTLDR = "Intel is crucial to a good attack strategy, and Zero is well aware of that. His Argus Launcher is equipped with very special cameras that can lodge themselves into breakable and reinforced surface to surveil either side.\n\nYes, these cameras can cover two angles and effectively allow you to spy on the opposing team. Argus Cameras do have one more quirk though: a single laser shot, perfect for destroying key elements in the Defenders’ setup or drawing attention away from choke points.",
                        AbilityDemoLink = "I6hswz4rIrU"
                    },
                    new Operator {
                        Name = "Dokkaebi",
                        OpImgLink = "/media/attackerMedia/attackerPortraits/dokkaebiPortrait.png",
                        OpIconLink = "/media/attackerMedia/attackerIcons/dokkaebi.png",
                        Role = "Anti Roam,Flank,Intel Denier,Intel Gatherer",
                        Origin = "707TH SMB",
                        Biography = "“You say potato, I say botnet.”\n\nNam's math and technology skills earned her a National Academic Excellence Scholarship at KAIST (the Korean Advanced Institute of Science and Technology). She served in the Republic of Korea Army (ROK), where her adeptness with technology saw her assigned to the 5163 Army Division. Looking for a chance from office life, Nam earned her place in the 9th Special Forces Brigade, known as the Ghost corps, where she trained in mountaineering, survival techniques, and guerrilla warfare. Highly adaptable, Nam often utilizes a creative, unorthodox approach to gets results. This skill didn’t go unnoticed by the USFK or the 707th Special Mission Battalion. Encouraged to focus on breaching defenses and exploiting weaknesses in networks, Nam was quickly recruited to the 707th and deployed alongside Specialist Chul Kyung Hwa, codename “Vigil,” until their recruitment into Rainbow. Nam works closely with Specialist Masaru “Echo” Enatsu in the R&D lab, engineering new countermeasure technologies.",
                        PshycoPortrait = "Grace Nam is playful, clever, serious, and reckless as her codename – Dokkaebi – implies. She’s also mischievous. Recent reports say she’s been pushing herself beyond her limits and the team has expressed concern that she’s over-confident. Added to that, we have past disciplinary reports stating that her actions have been “unorthodox,” which I can believe. I was there when she hacked the system; I saw the promise when other people wanted her punished. […]\n\nNam’s a talented operator. But it’s important to note that she’s one of the younger Rainbow recruits and has little combat experience. This job is intense, and the stakes are high. Some days, I have the impression she would rather be behind her computer, controlling things from where no one can touch her. But she wants to improve; she wants to change. And to do that, she has to challenge herself.\n\nI’m certain the over-confidence is about fear. She’s afraid she doesn’t belong, that she isn’t good enough. As for past discinplinary hearings, the shortcomings are with the commanders, not with Nam. A talented hacker isn’t just someone who’s good with code, they’re a creative thinker with the ability to see connections the rest of us can’t. Yes, there’s recklessness. Yes, there’s an element of bravado. But whatever else people may see, they must also admit that there’s a method to Nam’s madness. […]\n\nWhen I asked about her childhood, she boasted of schoolyard fights and described the extreme academic pressures she faced. The school would shame parents by publically comparing their children. She’s carried this burden of expectation throughout her life, so to have Specialist Chul Kyung “Vigil” Hwa chastise her creates a friction that Nam will have to address. […]\n\nShe told me her grandparents introduced her to Buddhism when she was little and that she’s recently begun visiting the temple again. I’m reassured. This is her way to cleanse her mind and spirit. Her pursuit of inner balance will allow Nam to achieve her full potential. Her bluster may irritate operators such as Specialist Yumiko “Hibana” Imagawa, but I say let her be.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 2,
                        Speed = 2,
                        Difficulty = 2,
                        OpSide = context.Side.Where(s => s.Name == "Attacker").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "DokkaebiLoadout").FirstOrDefault(),
                        AbilityName = "LOGIC BOMB",
                        AbilityIcon = "/media/attackerMedia/attackerAbilityIcons/Logic-Bomb.webp",
                        AbilityTLDR = "Grace utilizes the Ballistic Armor Military Laptop, codenamed Logic Bomb, which she uses to hack enemy PDA tactical devices. The program downloads a virus of her making that can bypass firewalls, turning surrounding devices on and emitting a loud noise to compromise an enemy’s position.",
                        AbilityDemoLink = "4MfOe_7J8u4"
                    },
                    new Operator
                    {
                        Name = "Hibana",
                        OpImgLink = "/media/attackerMedia/attackerPortraits/hibanaPortrait.png",
                        OpIconLink = "/media/attackerMedia/attackerIcons/hibana.png",
                        Role = "Back Line,Front Line,Hard Breach",
                        Origin = "S.A.T.",
                        Biography = "“Kyūdō is meditation in action. Explosions are part of that action.”\n\nImagawa is an expert in paramilitary techniques and infiltration of high-risk areas, demonstrating brilliant leadership skills in the field. Encouraged by her family, she has been practicing the long-range martial art of Kyūdō from an early age and possesses the ability to assess multiple factors simultaneously while executing precise, controlled, and fluid motions. Having trained with CTUs around the world including the SAS, FBI SWAT, and GIGN, Hibana has acquired a rare tactical versatility, with proficiency in tubular (bus, train, and airplane) assaults. During her studies at the National Police Academy, she gained the nickname Hibana due to her improvised explosive devices. Fluent in several languages and lethal with any weapon, Imagawa was recruited by the Aichi Prefectural Police Department Special Assault Team, where her diverse techniques and charisma resulted in her to moving quickly up the ranks.",
                        PshycoPortrait = "Specialist Yumiko “Hibana” Imagawa has considerable talents. I only know a few others with as many commendations. Inspiring operatives from diverse backgrounds and putting people at ease comes naturally to her, and she’s certainly gracious with my poor attempts at Japanese. […]\n\nI enjoy our conversations. Imagawa is very lyrical in the way she recounts her experiences. For someone who’s been around the world and encountered so many cultures, her favorite stories are of her childhood home. Like when her father would come home from his work as a butcher, and Imagawa’s mother wouldn’t allow him inside until they had hosed him down in the garden. The image of her drenched, barefoot father dancing under the spray of frigid water was a great amusement to the family. I like the story.\n\nMemories likese these keep us grounded and I wondered if training in Kyudo had fostered this appreciation in her. When I suggested that she had an aura of inner serenity, she laughed and called me a “hippie.” […] I’d like to see if she can influence some of the others to maintain that calm sensibility. Her training with so many CTUs makes her an ideal fit for the role. Already within Rainbow Imagawa is universally respected. […]\n\nI sense that Imagawa’s motivations are stoked by some inner fire, but she also has a competitive drive with fellow operatives. The debrief reports indicate as much. […] Imagawa does appear to be uncustomarily impatient with Specialist Grace “Dokkaebi” Nam, despite them often spending lab time together.\n\nThe dynamic surprises me because I can’t quite pin it down. When I asked, Imagawa said I was mistaken, and Dokkaebi seems not to notice or to care. I’ve read the reports and my hunch hovers over some joint training exercise with the GIGN. Imagawa may envy Nam’s easy self-assurance, which corresponds with records concerning Imagawa’s younger sister. Still, I’d like to explore this further. They aren’t necessarily at loggerheads, but it may affect future operations in some way we can’t foresee if I can’t determine the source of the rupture in Imagawa’s calm.\n\n-- Dr. Harishva “Harry” Pandey, Director of Rainbow",
                        Armor = 1,
                        Speed = 3,
                        Difficulty = 1,
                        OpSide = context.Side.Where(s => s.Name == "Attacker").FirstOrDefault(),
                        OpLoadout = context.Loadout.Where(l => l.Name == "HibanaLoadout").FirstOrDefault(),
                        AbilityName = "X-KAIROS",
                        AbilityIcon = "/media/attackerMedia/attackerAbilityIcons/X-Kairos.webp",
                        AbilityTLDR = "The X-KAIROS - a 40 mm caliber launcher - fires explosive pellets that can be detonated simultaneously from a distance. Deliver innovative assaults by creating lines of sights, or new pathways!",
                        AbilityDemoLink = "12hNVzz4CYY"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
