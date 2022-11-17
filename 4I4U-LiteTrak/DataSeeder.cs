using _4I4U_LiteTrak.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics;

namespace _4I4U_LiteTrak
{
    public class DataSeeder
    {
        readonly FeuDbContext _context;

        public DataSeeder(FeuDbContext context)
        {
            _context = context;
        }

        public void InitialiseDatabase()
        {
            if (_context == null) throw new ArgumentNullException(nameof(_context));

            if (!_context.Feus.Any())
            {
                var mockFeu1 = new Feu()
                {
                    Id = 1,
                    DoitClignoter = false,
                    InfoTraffic = 0,
                    TempsAjout = 0,
                    FeuxAval = new()
                };
                var mockFeu2 = new Feu()
                {
                    Id = 2,
                    DoitClignoter = false,
                    InfoTraffic = 0,
                    TempsAjout = 0,
                    FeuxAval = new()
                };
                mockFeu1.FeuxAval.Add(mockFeu2);
                var mockFeus = new List<Feu>() { mockFeu1, mockFeu2 };

                _context.Feus.AddRange(mockFeus);
            }

        }
    }
}
