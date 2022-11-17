using System.Reflection.Metadata.Ecma335;

namespace _4I4U_LiteTrak.Model
{

    public class Feu
    {
        public int Id { get; set; }
        public int InfoTraffic { get; set; }
        public int TempsAjout { get; set; }
        public bool DoitClignoter { get; set; }
        public virtual List<Feu>? FeuxAval { get; set; }
    }
}
