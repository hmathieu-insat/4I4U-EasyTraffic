using _4I4U_LiteTrak.Model;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _4I4U_LiteTrak.Services
{
    public class CalculerTempsAjout
    {
        private readonly List<Feu> listeFeux;
        public CalculerTempsAjout(List<Feu> feux)
        {
            listeFeux = feux;
        }

        public List<int> RecupererInfoTraffic()
        {
            List<int> ListInfoTraffic = new();
            foreach (Feu Feu in listeFeux)
            {
                ListInfoTraffic.Add(Feu.InfoTraffic);

            }
            return ListInfoTraffic;
        }

        public int CalculTempsAjout()
        {
            int count = 0;
            List<int> ListInfoTraffic = RecupererInfoTraffic();

            foreach (var value in ListInfoTraffic)
            {
                if (value > 3)
                {
                    count++;
                }
            }
            return count * 3;
        }



    }
}