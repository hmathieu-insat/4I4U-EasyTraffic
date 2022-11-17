using System.Reflection.Metadata.Ecma335;

namespace _4I4U_LiteTrak.Model
{
    public class Feu
    {
        public int InfoTraffic { get; set; }
        private int TempsAjout { get; set; }
        private bool DoitClignoter { get; set; }
        private List<Feu> FeuxAval { get; set; } = new();


    }
}
