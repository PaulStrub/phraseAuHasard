using System;

namespace coursCode
{
    class Program
    {

        public static void generatetest()
        {
            int num = 0;

            var sujets = new string[] {
                "Un lapin ",
                "Une grand-mère ",
                "Un chat ",
                "Un bonhomme de neige ",
                "Une limace ",
                "Une fee ",
                "Un magicien ",
                "Une tortue ",
                "Loic ",
                "Mon papi ",
                "Depardieu ",
                "InoxTag ",
                "Le Zéveunte ",
                "un dragon vert turquoise ",
                "un petit poids " ,
                "un livre ",
                "Denis Brogniart ",
                "un homme tout nu ",
                "maximilian en tutu ",
                "Hugo en jetsky ",
                "Alban et five guys ",
                "Victor aux cheveux doux ",
                "Mohamed qui s'est fait spoil SNK ",
                "la lune ",
                "Michel Drucker ",
                "Un cake marbré ",
                "une fenetre "
                };
            var Verbe = new string[]
            {
                "mange ",
                "détruit ",
                "gobe ",
                "attrape ",
                "par en guerre contre ",
                "attaque ",
                "carjack ",
                "goume ",
                "defenestre ",
                "créé ",
                "étudie ",
                "écoute ",
                "s'accroche ",
                "ferme ",
                "fais des bisous à ",
                "rackette "
            };

            

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("un nombre stp !");
                generatetest();
            }
            for (int i = 0; i < num; i = i+1)
            {
                string phrase = "";
                Random rands = new Random();
                int i1 = rands.Next(0, sujets.Length);
                Random randv = new Random();
                int i2 = randv.Next(0, Verbe.Length);
                Random randc = new Random();
                int i3 = randc.Next(0, Verbe.Length);
                phrase = phrase + sujets[i1] + Verbe[i2] + sujets[i3];
                
                if (verif(phrase) == false)
                {
                    Console.WriteLine(phrase);
                };

            }
            Console.WriteLine("t'as kiffé tu veux rejouer ? écrit oui si tu veux rejouer ");
            string rep = Console.ReadLine();
            if (rep == "oui")
            {
                Console.Clear();
                Console.WriteLine("Alors dis moi tu veux combien de phrases");
                generatetest();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("goodbye");
                replay();
            }
        }
        public static void replay()
        {
            string play = Console.ReadLine();
            
            if (play == "replay")
            {
                Console.Clear();
                Console.WriteLine("hooo tu es revenu alors dis moi combien en veux tu ?");
                generatetest();
            }
            else
            {
                replay();
            }
        }
        public static bool verif(string txt)
        {
            int doublons = 0;
            int doubleBef = 0;
            var Verif = new string[] { };
            for (int i = 0; i<Verif.Length; i++)
            {
                if (txt == Verif[i])
                {
                    doublons = doublons + 1;
                    return (true);
                }
            if (doubleBef != doublons)
                {
                    Verif[Verif.Length + 1] = (txt);
                    return (false);
                }

            }
            return (false);
        }

        // sujet verbe complement

        static void Main(string[] args)
        {


            Console.WriteLine("OOEEEEEEE ca va mon pote ? Je suis Akarias de AKARIASTV et on va te donner des phrases t'en veux combien ?");
            generatetest();
            


        }
        
    }
}
