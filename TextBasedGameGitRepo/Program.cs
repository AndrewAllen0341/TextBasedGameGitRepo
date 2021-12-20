using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using IntoTheFjordClassLibrary;

namespace TextBasedGame
{
    class Program
    {
        public static CompletedPlayer CompletedPlayer { get; private set; }

        static void Main(string[] args)
        {
            Console.Title = "Into the Fjord";
            Console.WriteLine(@"

                             _____      _          _   _             __ _               _ 
                            |_   _|    | |        | | | |           / _(_)             | |
                              | | _ __ | |_ ___   | |_| |__   ___  | |_ _  ___  _ __ __| |
                              | || '_ \| __/ _ \  | __| '_ \ / _ \ |  _| |/ _ \| '__/ _` |
                             _| || | | | || (_) | | |_| | | |  __/ | | | | (_) | | | (_| |
                             \___/_| |_|\__\___/   \__|_| |_|\___| |_| | |\___/|_|  \__,_|
                                                                      _/ |                
                                                                     |__/                 

                                             A Text Based Adventure Game
                                                  By: Andrew Allen



         The year is 913 AD and The Vikings Age is at its peak. All across Europe and the know world the vikings 
        have been raiding, colonized and settling in distant lands even making their way all the way to Newfounland 
        in North America. The Viking Kingdoms were drawn by the growth of wealthy towns, monasteries overseas, and 
        weak Kingdoms led by weak Kings. Not a single man, woman or child in around the world could withstand the 
        wrath of the Norsemen and today they will suffer yours.



                                        Press any key to begin your adventure.
                                 (Use the keyboard for all entries throughout the game)
                                                       
");

            #region Variables
            //Insert Running Variable Here.
            bool PlayGame = true;
            //Declared Weapons 
            Weapon sword = new Weapon(1, 10, "sword", 7);
            Weapon handAxe = new Weapon(1, 9, "axe", 8);
            Weapon longAxe = new Weapon(2, 12, "long axe", 4);

            #endregion

            do
            {
                //User choice to play the game
                string UserChoice = Console.ReadKey(true).Key.ToString();
                Console.Clear();
                Thread.Sleep(1000);
                Console.Write("Viking Shipmate - ");
                Thread.Sleep(500);
                Typewrite("A city, a city! I see a city in the distance! Prepare yourselves for battle!\n");
                Thread.Sleep(2000);
                //Maybe find a console beep rythm to simulate the drums beating for the oars
                Console.WriteLine($"" +
                    $"\n\nYou immediatly pull your oar in to get a better look, as soon as you stand up a strong wind from the North hits \n" +
                    $"your face bringing with it a heavy wet mist. You think to yourself how nice it will be to stretch your legs and walk \n" +
                    $"more than the few feet around the ship. Just as you get your first real look of the city you notice a sudden burst \n" +
                    $"of speed as many of the warriors move to the oars and begin to muscle the ship up to speed.\n\n");
                Thread.Sleep(18000);
                Console.Write("Viking Warrior - ");
                Thread.Sleep(500);
                Typewrite("Don't look so scared! Tell me, what's your name little lad? \n\n");
                Thread.Sleep(500);
                Console.Write("Type out your response: ");
                string UserInput = Console.ReadLine().ToLower(); //UserInput (make all lower to account for spelling mistakes)
                string UserName = char.ToUpper(UserInput[0]) + UserInput.Substring(1); //UserName (makes the first letter of the name caps and the rest lower cased)
                Console.Write("\nViking Warrior - ");
                Thread.Sleep(500);
                Typewrite($"Ahhhhh {UserName}, I'm Halfdan. Come close so we can pray the gods bless our blades and give \n" +
                    $"our enemies a swift death.\n");
                Thread.Sleep(1000);
                Console.Write("\nHalfdan - ");
                Thread.Sleep(500);
                Typewrite($"{UserName}, who do you pray to?\n\n" +
                    $"Is it Thor! The god of thunder and battle to help give you the courage needed to fight!\n" +
                    $"No, No it's Magni! The god of strength to help unburden the weight of your armor!\n" +
                    $"Or is it Loki? The god of mischief to help trick your enemies into an ususpecting death?\n");
                Thread.Sleep(2000);
                Console.WriteLine(@"
Closing your eyes for just a few seconds a vision of your mother comes to you, she is praying that you come home safe.

                                          Who do you choose to pray to?
                                                   A: Thor
                                                   B: Magni
                                                   C: Loki
                                                   D: No God");
                //User choice for their god (Bonus attributes)
                string UserGod = Console.ReadKey(true).Key.ToString();
                Prayer p = new Prayer();
                Console.Clear();

                //Perform an action based on UserGod (Use this to build character)
                switch (UserGod)
                {
                    case "A":
                        Console.Write($"{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("I pray to the Son of Odin! I pray to the mighty Thor!!\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nLooking off into the distance Halfdan turns his head back to you and begins to speak\n" +
                            "low rythmic tones.");
                        Thread.Sleep(1500);
                        Console.Write("\nHalfdan - ");
                        Thread.Sleep(500);
                        Typewrite("Heill sé pú ok í hugum góðum! Pórr pik piggi, Óðinn pik eigi.\n");
                        Thread.Sleep(2500);
                        Console.WriteLine("\nA sudden smile comes across Halfdans face as you begin to speak back.");
                        Thread.Sleep(2500);
                        Console.Write($"\n{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("Hail to you and be in good spirits! May Thor protect you and may Odin keep you.");
                        p = Prayer.Thor;
                        break;
                    case "B":
                        Console.Write($"{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("I pray to Magni! The strongest and mightiest of all the gods!\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nHalfdan jumps up ontop of his seat with his arms outstretched, head tilted straight back\n" +
                            "and begins to shout in a booming voice the gods must have heard!");
                        Thread.Sleep(2500);
                        Console.Write("\nHalfdan - ");
                        Thread.Sleep(500);
                        Typewrite("Magni!!! Magni!!! Magni!!!!!!\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nA sudden smile comes across your face and you jump to your seat to join Halfdan.");
                        Thread.Sleep(2500);
                        Console.Write($"\n{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("Hail Magni! Hail Magni! The god of brute strength! I honour you! Hail Magni!");
                        p = Prayer.Magni;
                        break;
                    case "C":
                        Console.Write($"{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("I pray to Loki.\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nLooking down at the knife Halfdan has in his hands he begins to twirl it and without looking\n" +
                            "up he mutters under his breath.");
                        Thread.Sleep(2500);
                        Console.Write("\nHalfdan - ");
                        Thread.Sleep(500);
                        Typewrite("Loki...... The sly one. I hope he hears your prayer.... and answers it in your favor.\n");
                        Thread.Sleep(2500);
                        Console.WriteLine("\nYou take a few steps towards Halfdan and pat him on the shoulder.");
                        Thread.Sleep(2500);
                        Console.Write($"\n{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("Battle is chaos and battle is change. Loki is chaos and Loki is change.");
                        p = Prayer.Loki;
                        break;
                    case "D":
                        Console.Write($"{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("If the gods are real why is there so much death and cruelty on Earth?\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nHalfdan drops his head not wanting to make eye contact.");
                        Thread.Sleep(2500);
                        Console.Write("\nHalfdan - ");
                        Thread.Sleep(500);
                        Typewrite("I hope the gods turned a deaf ear to that.\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nWanting to challenge Halfdan even more you look at him and say.");
                        Thread.Sleep(2000);
                        Console.Write($"\n{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("Valhalla isn't real and it's a waste of life trying to die to enter it's gates.");
                        p = Prayer.NoGod;
                        break;
                    default:
                        Thread.Sleep(1500);
                        Console.WriteLine("Halfdan looks at you smiling and belts out the loudest laugh you have ever heard outside\n" +
                            "of the tavern back home.");
                        Thread.Sleep(2500);
                        Console.Write("\nHalfdan - ");
                        Thread.Sleep(500);
                        Typewrite($"{UserName}! We have more gods than 5 men have fingers and you can't even name one!!\n" +
                            $"I'll pray double for the both of us.\n");
                        Thread.Sleep(2500);
                        Console.WriteLine("\nYou raise your right hand in the air as if to slam cups together at a feast.");
                        Thread.Sleep(2000);
                        Console.Write($"\n{UserName} - ");
                        Thread.Sleep(500);
                        Typewrite("You are already to kind to me Halfdan.");
                        p = Prayer.Invalid;
                        break;
                }
                Thread.Sleep(2000);
                Console.Write("\n\nHalfdan - ");
                Thread.Sleep(500);
                Typewrite("Enough talk for now. Get back to the oar, we need to get this ship to the city before we do any fighting.\n");
                Thread.Sleep(2500);
                Console.Write("\nYou sit back down and grab your oar with a new found motivation and purpose. You begin to row in rythm\n" +
                    "with the rest of the company.\n");
                Thread.Sleep(3500);
                Console.Write("\nThe muscles in your arms begin to ache and burn with every pull of the oar. We must be getting close by now.\n");
                Thread.Sleep(2500);
                Console.Write($"\n{UserName} - ");
                Thread.Sleep(500);
                Typewrite("Halfdan! Halfdan! How much longer are we going to have to row?\n");
                Thread.Sleep(1500);
                Console.Write("\nHalfdan - ");
                Thread.Sleep(500);
                Typewrite("Why are you asking me? Do I look like I'm in charge?\n");
                Thread.Sleep(2000);
                Console.WriteLine($"\nYou give the oar another great pull and seemingly like the gods were trying to answer your question\n" +
                    $"you hear a voice shout above the rythmic beats of the drums.\n");
                Thread.Sleep(2000);
                Console.Write("Viking Warrior - ");
                Typewrite("Grab your gear! We will ride the current into the beach!\n");
                Console.WriteLine("\nYou bring your oar in as quickly as your aching muscles will allow, standing up you lift the lid of your seat\n" +
                    "open and look inside. Moving the cloak to the side reveals the weapons that lay beneath.");
                Console.WriteLine(@"
                                           What weapon do you choose?
                                                   A: Sword
                                                   B: Axe
                                                   C: Long Axe");
                //User choice for their god (Bonus attributes)
                string UserWeapon = Console.ReadKey(true).Key.ToString();

                Console.Clear();
                switch (UserWeapon)
                {
                    case "A":
                        Console.Clear();
                        Console.WriteLine("Moving swiftly you grab the short sword and fix the scabbard to the belt wrapped around your waiste.\n");
                        Thread.Sleep(2500);
                        Console.Write("Halfdan - ");
                        Thread.Sleep(500);
                        Typewrite($"{UserName} let's hope that sword is sharper than it looks! Stick with me and maybe you shall see the \n" +
                            $"halls of Valhalla one day.\n");
                        CompletedPlayer = new CompletedPlayer(UserName, 70, 5, 50, 50, p, sword);
                        break;
                    case "B":
                        Console.Clear();
                        Console.WriteLine("Moving swiftly you grab the axe and hold it up in the air to inspect it.\n");
                        Thread.Sleep(2500);
                        Console.Write("Halfdan - ");
                        Thread.Sleep(500);
                        Typewrite($"{UserName} let's hope that axe is sharper than it looks! Stick with me and maybe you shall see the \n" +
                            $"halls of Valhalla one day.\n");
                        CompletedPlayer = new CompletedPlayer(UserName, 70, 5, 50, 50, p, handAxe);
                        break;
                    case "C":
                        Console.Clear();
                        Console.WriteLine("Moving swiftly you grab the long axe and raise it above your head with both hands.\n");
                        Thread.Sleep(2500);
                        Console.Write("Halfdan - ");
                        Thread.Sleep(500);
                        Typewrite($"{UserName} let's hope that long axe isn't too heavy for you! Stick with me and maybe you shall see the \n" +
                            $"halls of Valhalla one day.\n");
                        CompletedPlayer = new CompletedPlayer(UserName, 70, 5, 50, 50, p, longAxe);
                        break;
                    default:
                        Console.Clear();
                        Weapon[] weapons = { sword, handAxe, longAxe };
                        int randomIndex = new Random().Next(weapons.Length);
                        Weapon weapon = weapons[randomIndex];
                        Console.WriteLine($"Fumbling through the seat you grab the first thing you get your hands on and lift it into the \n" +
                            $"air. It is the {weapon.Name}, thankfully you have been training heavily with this back home.\n");
                        Thread.Sleep(2500);
                        Console.Write("Halfdan - ");
                        Thread.Sleep(500);
                        Typewrite($"{UserName} that might be the rusties {weapon.Name} I have ever seen! Stick with me and maybe you shall see the \n" +
                            $"halls of Valhalla one day.\n");
                        CompletedPlayer player = new CompletedPlayer(UserName, 70, 5, 50, 50, p, weapon);
                        break;
                }//End of weapon switch
                Thread.Sleep(3500);
                Console.WriteLine("\nHalfdan belts out a booming roar and runs towards the edge of the ship. He leaps down and lands in knee deep water\n" +
                    "and begins to walk slowly towards the beach. Standing on the slightly elevated beach head is a handful of men with \n" +
                    "hatchets, pitchforks and other farm equipment prepared to meet us head on.\n");
                Thread.Sleep(3500);
                Console.WriteLine("Halfdan turns around waving his arms for you to come forward\n");
                Thread.Sleep(1500);
                Console.Write("Halfdan - ");
                Typewrite($"You better get over here! Battle doesn't wait for anyone, not even you {UserName}!\n\n");
                Console.WriteLine("As your feet hit the ground you feel your adrenaline begin to kick in and heighten you senses.\n" +
                    "You begin to run forward to meet the opposition head on. All around you, you hear the clatter of steel,\n" +
                    "screams of the dying and thuds of bodies hitting the compact sand. You look up and lock eyes with your \n" +
                    "foe for the first time.\n");
                #region 1st Encounter
                Peasant p1 = new Peasant();
                Peasant p2 = new Peasant();
                Merchant m1 = new Merchant();
                Enemy[] enemies = { p1, p2, m1 };
                int RandomIndex = new Random().Next(enemies.Length);
                Enemy enemy = enemies[RandomIndex];
                #endregion
                Console.WriteLine($"Swinging the {CompletedPlayer.EquippedWeapon.Name} at your side you begin to walk towards the {enemy.Name}.\n" +
                    $"The {enemy.Name} steps forward to meet you on the field, a brave but stupid move.");
                while (CompletedPlayer.Life > 0 && enemy.Life > 0)
                {
                    
                    Console.WriteLine(@"



                                            Please choose an action:
                                            A: Press the attack.
                                            B: Sit back in guarded stance.
                                            C: Player Info.
                                            D: Enemy Info.");

                    UserChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (UserChoice)
                    {
                        case "A":
                            Combat.DoBattle(CompletedPlayer, enemy);
                            break;
                        case "B":
                            CombatBlock.DoBattleBlock(CompletedPlayer, enemy);
                            break;
                        case "C":
                            Console.WriteLine(CompletedPlayer);
                            break;
                        case "D":
                            Console.WriteLine(enemy);
                            break;
                        default:
                            break;
                    }
                }
                Thread.Sleep(1500);
                Console.WriteLine($"\nYour foe drops to the sand clutching at his wounds, he fought well for a simple {enemy.Name}.\n" +
                    $"You get down one knee to get closer to your foe, the {enemy.Name} reaches up to you with bloody hands and grabs\n" +
                    $"your {CompletedPlayer.EquippedWeapon.Name} and places the blade against his chest. You lean in with all your\n" +
                    $"weight.\n");
                Thread.Sleep(6000);
                Console.WriteLine("He will no longer suffer.");
                Thread.Sleep(2000);
                Console.WriteLine("\nHalfdan turns to you with a bloodied tunic.");
                Thread.Sleep(1500);
                Console.Write("Halfdan - ");
                Thread.Sleep(500);
                Typewrite($"Don't look worried lad it's not my blood. We need to keep moving before they have time to rally the \n" +
                    $"fighting men.");
                Thread.Sleep(1000);
                Console.WriteLine("\nMoving swiftly you gather with the rest of the men and begin to move towards the city. Directly up the road \n" +
                    "is a small wooden guard house, you can see shadows and silhouettes of men moving inside.\n");
                Thread.Sleep(1500);
                Console.WriteLine("Moving in sync almost like a flock of birds moving at once the front line of warrior begin to form a shield wall\n" +
                    "for protection.");
                Thread.Sleep(1500);
                Console.WriteLine("Rocks, arrows and other projectiles bounce off of the shield wall like waves on the bow of a ship on open water and \n" +
                    "just like our ships nothing can stop what is already in motion.\n");
                Thread.Sleep(1500);
                Console.Write("Halfdan - ");
                Typewrite($"{UserName} you have fought well so far but the battle has just begun, as soon as we get to the \n" +
                    $"guard house we make our move.\n");
                Thread.Sleep(1500);
                Console.Write($"{UserName} - ");
                Typewrite("I am with you to the end!\n");
                Thread.Sleep(1500);
                Console.WriteLine("Halfdan gives you a look, an untold sign between the two of you and you both break ranks around the shield wall\n" +
                    "to engage the enenmy.");
                Thread.Sleep(2000);



            } while (PlayGame);
        }//End SVM
        static void Typewrite(string message) //Typewrite class to print out text
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }
        }//End Typewrite Class
    }//End Class
}//End namespace