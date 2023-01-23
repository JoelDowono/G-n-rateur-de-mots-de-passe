using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur: Le nombre doit être positif et non nul");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                //valide
                return nombre;
            }
            if(messageErreurPersonnalise == null)
            {
                Console.WriteLine("ERREUR : le nombre doit être compris entre " + min + " et " + max);
            }
            else
            {
                Console.WriteLine(messageErreurPersonnalise);
            }
            Console.WriteLine();
            return DemanderNombreEntre(question, min, max, messageErreurPersonnalise);
        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("Erreur: Vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
