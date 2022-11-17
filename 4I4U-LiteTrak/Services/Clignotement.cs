using _4I4U_LiteTrak.Model;

namespace _4I4U_LiteTrak.Services
{
    public class Clignotement
    {
        public List<Feu> listeFeux { get; private set; }
        public Clignotement(List<Feu> liste)
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
        public bool calculDoitClignoter(ListInfoTraffic)
        {
                public bool DoitClignoter = 0;
                public int count = 0;
                List<int> ListInfoTraffic = recupererInfoTraffic(listeFeux);
                foreach (value in ListInfoTraffic) {
                    if (ListeInfoTraffic(value) > 5) {
                        count++;
                }
                if (count > 2) {
                    DoitClignoter = 1;
                } else
                {
                    DoitClignoter = 0;
                }
                return DoitClignoter;

            }

    }
}
