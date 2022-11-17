using _4I4U_LiteTrak.Model;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _4I4U_LiteTrak.Services
{
    public class CalculerTempsAjout
    {
        public List<Feu> listeFeux { get; }
        public CalculerTempsAjout(List<Feu> liste)
        {
            listeFeux = liste;
        }
        public List<int> recupererInfoTraffic(List<Feu> Feux)
        {
            List<int> ListInfoTraffic = new();
            foreach (Feu Feu in Feux)
            {
                ListInfoTraffic.Add(Feu.InfoTraffic);

            }
            return ListInfoTraffic;
        }
    public int CalculTempsAjout()
    {
        public int count = 0;
        public int TempsAjout;
            List<int> ListInfoTraffic = recupererInfoTraffic(listeFeux);
            foreach public List<Feu> Feux { get; private set; }


        (value in ListInfoTraffic) {
                if (ListInfoTraffic(value)) {
                    count ++;
                }
            }
            case 1 :
                if (count = 1)
                {
                    
                }

        }

    }
}
