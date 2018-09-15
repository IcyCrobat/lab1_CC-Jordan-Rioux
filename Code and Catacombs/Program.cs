using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_and_Catacombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int s = 0;
            int d = 0;
            int l = 0;
            int hp = 0;
            int i = 0;
            int c = 0;

            Random rng = new Random();
            int doorlum = rng.Next(1, 101);
            int air1 = rng.Next(1, 101);
            int air2 = rng.Next(1, 101);
            int air3 = rng.Next(1, 101);

            string name = ("name");
            int enter = 0;
            int door1 = 0;
            int dropkick = 0;
            int stay = 0;
            int lumexit = 0;
            int stele = 0;


            //start
            /*
            Console.WriteLine("loading.");
            Console.WriteLine("0%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("1%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("3%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("7%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("11%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("15%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("17%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("22%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("24%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("27%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("31%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("34%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("35%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("39%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("42%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("47%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("50%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("52%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("55%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("58%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("61%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("63%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("67%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("70%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("71%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("74%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("75%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("77%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("79%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("83%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("86%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("89%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("91%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("94%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("97%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading...");
            Console.WriteLine("98%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading.");
            Console.WriteLine("99%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("loading..");
            Console.WriteLine("100%");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            */
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("loading complete");
            Console.WriteLine("click to continue");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Bienvenue dans Code & Catacombs");
            Console.ReadKey();

            Console.WriteLine("entré votre nom");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("le maximun de stat est de 60 répartis sur 5 stat");

            Console.WriteLine("entré force");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entré dexterité");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entré constitution");
            l = Convert.ToInt32(Console.ReadLine());
            hp = l;
            Console.WriteLine("entré intelligence");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entré charisme");
            c = Convert.ToInt32(Console.ReadLine());

            if (s + d + l + i + c > 60)
            {
                System.Environment.Exit(1);
            }

            Console.WriteLine(name + ", ton aventure est sur le point de commencer");
            Console.ReadKey();

            Console.Clear();

            if (l == 0)
            {
                Console.WriteLine("vous marchez 1 pas et mourer instantanement de cause de cancer du SIDA ébolique");
                System.Threading.Thread.Sleep(5000);
                System.Environment.Exit(1);
            }

            Console.WriteLine("vous arrriver a l'entrer d'un donjon, tapez 1 pour entrer ou 2 pour completement ignorer le donjon");
            enter = Convert.ToInt32(Console.ReadLine());
            if (enter == 2)
            {
                Console.WriteLine("lol, K");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.WriteLine("vous vous aventurer profondement dans le donjon, l'interieur est extremement sombre mais vous arriver a discerné une    porte en bois massif et une autre porte qui laisse passer un peu de lumiere");
            if (air1 == 1)
            {
                Console.WriteLine("lol vous avez oublier de respirer");
                System.Threading.Thread.Sleep(4000);
                System.Environment.Exit(1);
            }
            Console.WriteLine("tapez 1 pour ouvrir la porte en bois ou 2 pour entrer dans la porte lumineuse");
            door1 = Convert.ToInt32(Console.ReadLine());
            if (door1 == 1)
            {
                Console.WriteLine("la porte en bois est verrouiller voulez vous essayer de l'enfoncé");
                Console.WriteLine("tapez 1 pour l'enfoncé ou 2 pour aller dans l'autre porte");
                dropkick = Convert.ToInt32(Console.ReadLine());
                if (dropkick == 1)
                {
                    if (s >= 16)
                    {
                        Console.Clear();
                        Console.WriteLine("vous drop kické la porte et passé au travers");
                        Console.WriteLine("un fois de l'autre coté,  vous decouvrez une piece tres sombre et vous senter un courant d'air frais");
                        Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                        stay = Convert.ToInt32(Console.ReadLine());
                        if (stay == 2)
                        {
                            Console.WriteLine("il ne se passe rien");
                            Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                            stay = Convert.ToInt32(Console.ReadLine());
                            if (stay == 2)
                            {
                                Console.WriteLine("il ne se passe rien");
                                Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                                stay = Convert.ToInt32(Console.ReadLine());
                                if (stay == 2)
                                {
                                    Console.WriteLine("il ne se passe rien");
                                    Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                                    stay = Convert.ToInt32(Console.ReadLine());
                                    if (stay == 2)
                                    {
                                        Console.WriteLine("il ne se passe rien");
                                        Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                                        stay = Convert.ToInt32(Console.ReadLine());
                                        if (stay == 2)
                                        {
                                            Console.WriteLine("il ne se passe rien");
                                            Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                                            stay = Convert.ToInt32(Console.ReadLine());
                                            if (stay == 2)
                                            {
                                                Console.WriteLine("il ne se passe rien");
                                                Console.WriteLine("tapez 1 pour continuer votre exploration ou tapez 2 pour rester");
                                                stay = Convert.ToInt32(Console.ReadLine());
                                                if (stay == 2)
                                                {
                                                    Console.WriteLine("Bravo vous avez montrez votre determination");
                                                    Console.WriteLine("vous etes teleporter au tresor et gagner");
                                                    System.Threading.Thread.Sleep(4000);
                                                    System.Environment.Exit(1);

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        suite();
                    }
                    else
                    {
                        Console.WriteLine("la porte est trop solide vous vous casser la gueule pis les deux jambes");
                        Console.WriteLine("hint: le jeu est unfair");
                        Console.ReadKey();
                        System.Environment.Exit(1);
                    }
                }
                Console.WriteLine("vous decider de prendre l'autre porte");
                Console.ReadKey();


            }
            Console.WriteLine("une fois passer par la porte lumineuse, vous etes éblouie par la lumiere");

            if (doorlum <= 17)
            {
                Console.WriteLine("vous macher sur la queue d'un rat qui commence a courir et fait tomber un balai qui fait peur a un corbeau qui crie,    effrayant un chat qui fait tomber un chandelier, qui met le feu au tapis vous vous precipitez donc pour l'éteindre et   dans votre course vous vous enfarger dans le tapis et vous prenez 3 de degat");
                Console.ReadKey();
                hp = hp - 3;
                if (hp <= 0)
                {
                    Console.WriteLine("vous etes mort");
                    System.Threading.Thread.Sleep(4000);
                    System.Environment.Exit(1);
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("vous vous retrouvez dans une magnifique piece éclairer par un magnifique chandelier");
                Console.WriteLine("dans cette piece vous retrouver un chat qui dors dans un coin et un corbeau en cage, le sol de la piece est recoouvert  d'un magnifique tapis rouge");

            }
            Console.WriteLine("pour sortir de cette piece vous pouvez passer par la porte (1) ou continuez par un couloir (2)");
            lumexit = Convert.ToInt32(Console.ReadLine());
            if (lumexit == 1)
            {
                Console.WriteLine("vous passer par la porte et vous vous retrouvez devant une stele vide");
                if (name[0] == 'c' && i >= 14)
                {
                    Console.WriteLine("en vous approchant, votre nom apprait sur la stele ");
                    Console.WriteLine("voulez voulez touchez la stele (1) ou retournez dans la piece precedante pour continuer dans le couloir");
                    stele = Convert.ToInt32(Console.ReadLine());
                    if (stele == 1)
                    {
                        Console.WriteLine("au moment ou votre main se pose sur la stele une lumiere englobe toute la piece");
                        Console.WriteLine("vous vous retrouvez teleporter");
                        last();
                    }
                }
                Console.WriteLine("la stele ne fait rien donc vous decider de retourner en arriere pour prendre le couloir");
                Console.ReadKey();
            }
            suite();
        }

        static void suite()
        {
            int ddoor = 0;
            int conseil = 0;
            int esca = 0;
            int vieux = 0;
            int inter = 0;
            int fight = 0;

            Random rng = new Random();

            int air2 = rng.Next(1, 101);
            int air3 = rng.Next(1, 101);
            int stab = rng.Next(1, 101);

            Console.Clear();
            Console.WriteLine("vous continuez votre exploration a travers le couloir et arriver dans une grande salle ronde avec deux porte identique");
            Console.WriteLine("tapez 1 pour aller a gauche ou 2 pour aller a droite");
            ddoor = Convert.ToInt32(Console.ReadLine());
            if (ddoor == 2)
            {
                Console.WriteLine("le jeu vous conseille d'aller a gauche, voulez vous l'écouter");
                Console.WriteLine("tapez 1 pour ecouter le jeu et aller a gauche ou tapez 2 pour ignorer le conseil du jeu");
                conseil = Convert.ToInt32(Console.ReadLine());
                if (conseil == 2)
                {
                    Console.WriteLine("vous continuer a droite en ignorant le conseil du jeu et soudainement..........");
                    System.Threading.Thread.Sleep(2500);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("vos donnée on été supprimer #Only Monika");
                    System.Threading.Thread.Sleep(4000);
                    System.Environment.Exit(1);
                }
            }
            Console.WriteLine("vous decider d'aller a gauche ");
            Console.ReadKey();

            if (air2 == 1)
            {
                Console.WriteLine("lol vous avez oublier de respirer");
                System.Threading.Thread.Sleep(4000);
                System.Environment.Exit(1);
            }
            Console.WriteLine("vous vous enfoncer plus profondement dans le couloir ");
            Console.WriteLine("vous vous retrouver ensuite devant un tres grand escalier et vous remarquer aussi une porte ouverte a votre gauche");
            Console.WriteLine("tapez 1 pour monter l'escalier ou 2 pour passer par la porte");
            esca = Convert.ToInt32(Console.ReadLine());
            if (esca == 1)
            {
                Console.WriteLine("une fois en haut de l'escalier, vous vous retrouveer dans une petite piece ronde avec un foyer au millieu de la salle");
                Console.WriteLine("un veillard est assi sur le sol ");
                Console.WriteLine("tapez 1 pour continuer votre exploration ou 2 pour parler au veillard");
                vieux = Convert.ToInt32(Console.ReadLine());
                if (vieux == 2)
                {
                    Console.WriteLine("vous vous approcher du veillard");
                    if (stab <= 21)
                    {
                        Console.WriteLine("le veillard vous stab dans la gorge");
                        Console.WriteLine("vous perdez tout votre sang et mourrez");
                        System.Threading.Thread.Sleep(3000);
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("veillard: ...");
                        Console.WriteLine("le veillard refuse de vous parlez vous continuez donc votre explration");

                    }

                }
                else
                {
                    Console.WriteLine("vous continuez votre exploration");
                }
            }
            else
            {
                Console.WriteLine("vous passer par la porte et decouvrer un long couloir, en continuant dans le couloir vous arriver a une intersection");
                Console.WriteLine("d'un coté, un couloir qui mene a des escaliers et de l'autre un couloir extremement sombre");
                Console.WriteLine("tapez 1 pour aller vers les escaliers ou 2 pour continuer dans le noir");
                inter = Convert.ToInt32(Console.ReadLine());
                if (inter == 2)
                {
                    Console.WriteLine("a la fin du couloir sombre, vous decouvrer une salle rempli d'armure");
                    Console.WriteLine("soudainement, les armure se mette a bouger");
                    Console.WriteLine("tapez 1 pour essayer de courir vers la prochaine piece ou 2 pour vous battre et tenter de recuperer du loot");
                    fight = Convert.ToInt32(Console.ReadLine());
                    if (fight == 2)
                    {
                        Console.WriteLine("vous tenter courageusement de vous battre mais les armure sont bien trop puissante");
                        Console.WriteLine("vous perdez le combat et mourer");
                        System.Threading.Thread.Sleep(4000);
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("vous courez comme vous n'avez jamais courru auparavent, esquivant de peut les coups d'épées");
                    }

                }

            }

            last();


        }
        static void last()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("vous vous retrouver dans ce qui ressemble a une salle du trone");
            Console.WriteLine("sur le trone se trouve une magnifique épée ainsi que des pieces d'armures vous les enfilez et sentez votre energie se   multiplier");
            Console.WriteLine("vous possedé maintenant la force de teracé ce qui barre votre chemin");
            Console.WriteLine("une porte gigantesque se trouve derriere le trone ");
            Console.WriteLine("vous avancer sans peur vers la porte avec une musique épique qui joue dans votre tete (j'avais pas assez de budget pour les console.beep)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("apres une longue descente dans les catacombre du donjon vous arriver finalement devant un immense dragon");

            boss();

        }
        static void boss()
        {
            int HPmax = 100;
            int HP = 0;
            HP = HPmax;
            int bosshp = 200;
            Random rng = new Random();

            int attack1 = rng.Next(1, 101);
            int attack2 = rng.Next(1, 101);
            int attack3 = rng.Next(1, 101);
            int attack4 = rng.Next(1, 101);
            int attack5 = rng.Next(1, 101);
            int attack6 = rng.Next(1, 101);
            int attack7 = rng.Next(1, 101);
            int attack8 = rng.Next(1, 101);
            int air3 = rng.Next(1, 101);
            int crit1 = rng.Next(1, 101);
            int crit2 = rng.Next(1, 101);
            int crit3 = rng.Next(1, 101);
            int crit4 = rng.Next(1, 101);
            int crit5 = rng.Next(1, 101);
            int crit6 = rng.Next(1, 101);
            int crit7 = rng.Next(1, 101);
            int crit8 = rng.Next(1, 101);

            Console.ReadKey();
            Console.Clear();

            if (attack1 <= 60)
            {
                Console.WriteLine(HP + "/100");
                Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                HP = HP - 10;
            }
            else if (attack1 >= 61 && attack1 <= 90) 
            {
                Console.WriteLine(HP + "/100");
                Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                HP = HP - 15;
            }
            else 
            {
                Console.WriteLine(HP + "/100");
                Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                HP = HP - 30;
            }
            Console.ReadKey();
            if (HP <=0)
            {
                Console.WriteLine("vous etes mort en combattant le dragon");
                System.Threading.Thread.Sleep(3000);
                System.Environment.Exit(1);
            }
            Console.WriteLine("vous saisissez votre épée et attaquer");
            if (crit1 <= 20)
            {
                Console.WriteLine(HP + "/100");
                Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                bosshp = bosshp - 50;
            }
            else
            {
                Console.WriteLine(HP + "/100");
                Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                bosshp = bosshp - 25;
            }

            if (bosshp >0)
            {
                Console.ReadKey();
                Console.Clear();

                if (attack2 <= 60)
                {
                    Console.WriteLine(HP + "/100");
                    Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                    HP = HP - 10;
                }
                else if (attack2 >= 61 && attack2 <= 90)
                {
                    Console.WriteLine(HP + "/100");
                    Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                    HP = HP - 15;
                }
                else
                {
                    Console.WriteLine(HP + "/100");
                    Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                    HP = HP - 30;
                }
                Console.ReadKey();
                if (HP <= 0)
                {
                    Console.WriteLine("vous etes mort en combattant le dragon");
                    System.Threading.Thread.Sleep(3000);
                    System.Environment.Exit(1);
                }
                Console.WriteLine("vous saisissez votre épée et attaquer");
                if (crit2 <= 20)
                {
                    Console.WriteLine(HP + "/100");
                    Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                    bosshp = bosshp - 50;
                }
                else
                {
                    Console.WriteLine(HP + "/100");
                    Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                    bosshp = bosshp - 25;
                }

                if (bosshp > 0)
                {
                    Console.ReadKey();
                    Console.Clear();

                    if (attack3 <= 60)
                    {
                        Console.WriteLine(HP + "/100");
                        Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                        HP = HP - 10;
                    }
                    else if (attack3 >= 61 && attack3 <= 90)
                    {
                        Console.WriteLine(HP + "/100");
                        Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                        HP = HP - 15;
                    }
                    else
                    {
                        Console.WriteLine(HP + "/100");
                        Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                        HP = HP - 30;
                    }
                    Console.ReadKey();
                    if (HP <= 0)
                    {
                        Console.WriteLine("vous etes mort en combattant le dragon");
                        System.Threading.Thread.Sleep(3000);
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("vous saisissez votre épée et attaquer");
                    if (crit3 <= 20)
                    {
                        Console.WriteLine(HP + "/100");
                        Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                        bosshp = bosshp - 50;
                    }
                    else
                    {
                        Console.WriteLine(HP + "/100");
                        Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                        bosshp = bosshp - 25;
                    }

                    if (bosshp > 0)
                    {
                        Console.ReadKey();
                        Console.Clear();

                        if (attack4 <= 60)
                        {
                            Console.WriteLine(HP + "/100");
                            Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                            HP = HP - 10;
                        }
                        else if (attack4 >= 61 && attack4 <= 90)
                        {
                            Console.WriteLine(HP + "/100");
                            Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                            HP = HP - 15;
                        }
                        else
                        {
                            Console.WriteLine(HP + "/100");
                            Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                            HP = HP - 30;
                        }
                        Console.ReadKey();
                        if (HP <= 0)
                        {
                            Console.WriteLine("vous etes mort en combattant le dragon");
                            System.Threading.Thread.Sleep(3000);
                            System.Environment.Exit(1);
                        }
                        Console.WriteLine("vous saisissez votre épée et attaquer");
                        if (crit4 <= 20)
                        {
                            Console.WriteLine(HP + "/100");
                            Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                            bosshp = bosshp - 50;
                        }
                        else
                        {
                            Console.WriteLine(HP + "/100");
                            Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                            bosshp = bosshp - 25;
                        }

                        if (bosshp > 0)
                        {
                            Console.ReadKey();
                            Console.Clear();

                            if (attack5 <= 60)
                            {
                                Console.WriteLine(HP + "/100");
                                Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                                HP = HP - 10;
                            }
                            else if (attack5 >= 61 && attack5 <= 90)
                            {
                                Console.WriteLine(HP + "/100");
                                Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                                HP = HP - 15;
                            }
                            else
                            {
                                Console.WriteLine(HP + "/100");
                                Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                                HP = HP - 30;
                            }
                            Console.ReadKey();
                            if (HP <= 0)
                            {
                                Console.WriteLine("vous etes mort en combattant le dragon");
                                System.Threading.Thread.Sleep(3000);
                                System.Environment.Exit(1);
                            }
                            Console.WriteLine("vous saisissez votre épée et attaquer");
                            if (crit5 <= 20)
                            {
                                Console.WriteLine(HP + "/100");
                                Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                                bosshp = bosshp - 50;
                            }
                            else
                            {
                                Console.WriteLine(HP + "/100");
                                Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                                bosshp = bosshp - 25;
                            }

                            if (bosshp > 0)
                            {
                                Console.ReadKey();
                                Console.Clear();

                                if (attack6 <= 60)
                                {
                                    Console.WriteLine(HP + "/100");
                                    Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                                    HP = HP - 10;
                                }
                                else if (attack6 >= 61 && attack6 <= 90)
                                {
                                    Console.WriteLine(HP + "/100");
                                    Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                                    HP = HP - 15;
                                }
                                else
                                {
                                    Console.WriteLine(HP + "/100");
                                    Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                                    HP = HP - 30;
                                }
                                Console.ReadKey();
                                if (HP <= 0)
                                {
                                    Console.WriteLine("vous etes mort en combattant le dragon");
                                    System.Threading.Thread.Sleep(3000);
                                    System.Environment.Exit(1);
                                }
                                Console.WriteLine("vous saisissez votre épée et attaquer");
                                if (crit6 <= 20)
                                {
                                    Console.WriteLine(HP + "/100");
                                    Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                                    bosshp = bosshp - 50;
                                }
                                else
                                {
                                    Console.WriteLine(HP + "/100");
                                    Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                                    bosshp = bosshp - 25;
                                }

                                if (bosshp > 0)
                                {
                                    Console.ReadKey();
                                    Console.Clear();

                                    if (attack7 <= 60)
                                    {
                                        Console.WriteLine(HP + "/100");
                                        Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                                        HP = HP - 10;
                                    }
                                    else if (attack7 >= 61 && attack7 <= 90)
                                    {
                                        Console.WriteLine(HP + "/100");
                                        Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                                        HP = HP - 15;
                                    }
                                    else
                                    {
                                        Console.WriteLine(HP + "/100");
                                        Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                                        HP = HP - 30;
                                    }
                                    Console.ReadKey();
                                    if (HP <= 0)
                                    {
                                        Console.WriteLine("vous etes mort en combattant le dragon");
                                        System.Threading.Thread.Sleep(3000);
                                        System.Environment.Exit(1);
                                    }
                                    Console.WriteLine("vous saisissez votre épée et attaquer");
                                    if (crit7 <= 20)
                                    {
                                        Console.WriteLine(HP + "/100");
                                        Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                                        bosshp = bosshp - 50;
                                    }
                                    else
                                    {
                                        Console.WriteLine(HP + "/100");
                                        Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                                        bosshp = bosshp - 25;
                                    }

                                    if (bosshp > 0)
                                    {
                                        Console.ReadKey();
                                        Console.Clear();

                                        if (attack8 <= 60)
                                        {
                                            Console.WriteLine(HP + "/100");
                                            Console.WriteLine("le dragon vous attaque avec un coup de griffe vous causant 10 de degat");
                                            HP = HP - 10;
                                        }
                                        else if (attack8 >= 61 && attack8 <= 90)
                                        {
                                            Console.WriteLine(HP + "/100");
                                            Console.WriteLine("le dragon vous attaque avec une morsure vous causant 15 de degat");
                                            HP = HP - 15;
                                        }
                                        else
                                        {
                                            Console.WriteLine(HP + "/100");
                                            Console.WriteLine("le dragon vous attaque en vous crachant du feux vous causant 30 de degat");
                                            HP = HP - 30;
                                        }
                                        Console.ReadKey();
                                        if (HP <= 0)
                                        {
                                            Console.WriteLine("vous etes mort en combattant le dragon");
                                            System.Threading.Thread.Sleep(3000);
                                            System.Environment.Exit(1);
                                        }
                                        Console.WriteLine("vous saisissez votre épée et attaquer");
                                        if (crit8 <= 20)
                                        {
                                            Console.WriteLine(HP + "/100");
                                            Console.WriteLine("vous donner un magnifique coup d'épée causant d'énorme dégat au dragon");
                                            bosshp = bosshp - 50;
                                        }
                                        else
                                        {
                                            Console.WriteLine(HP + "/100");
                                            Console.WriteLine("vous donner un coup au dragon causant quelque dégat");
                                            bosshp = bosshp - 25;
                                        }
                                       
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("felicitation vous avez réussi a triompher du dragon avec succes");
            if (air3 <= 2)
            {
                Console.WriteLine("lol vous avez oublier de respirer");
                System.Threading.Thread.Sleep(4000);
                System.Environment.Exit(1);
            }
            Console.WriteLine("vous avez maintenant un trésor d'une valeur de 42.50 $");
            System.Threading.Thread.Sleep(6000);
            System.Environment.Exit(1);

        }
    }
}
