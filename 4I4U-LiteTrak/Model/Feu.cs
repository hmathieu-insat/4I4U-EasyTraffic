using _4I4U_LiteTrak.Services;
using System.Reflection.Metadata.Ecma335;

namespace _4I4U_LiteTrak.Model
{

    public class Feu
    {
        public int Id { get; set; }

        private int infoTraffic;
        public int InfoTraffic
        {
            get => infoTraffic;
            set
            {
                OnInfoTrafficUpdate();
                infoTraffic = value;
            }
        }

        public int TempsAjout { get; set; }
        public bool DoitClignoter { get; set; }
        public virtual List<Feu>? FeuxAval { get; set; }

        private void OnInfoTrafficUpdate()
        {
            TempsAjout = new CalculerTempsAjout(FeuxAval).CalculTempsAjout();
        }
    }

}
