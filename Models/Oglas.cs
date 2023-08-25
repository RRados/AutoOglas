using System.Collections.Generic;
using System.Linq;

namespace WebAppOglas.Models
{
    public class Oglas
    {
        public static void DodajOglas(Automobil automobil)
        {
            MvcOglasContext oglasContext = new MvcOglasContext();

            oglasContext.Automobil.Add(automobil);

            oglasContext.SaveChanges();
        }

        public static List<Automobil> UzmiOglas()
        {
            MvcOglasContext dbContext = new MvcOglasContext();

            return dbContext.Automobil.ToList();
        }

        public static void Obrisi(Automobil automobil)
        {
            MvcOglasContext oglasContext = new MvcOglasContext();

            oglasContext.Remove(automobil);

            oglasContext.SaveChanges();
        }

        public static void Izmeni(Automobil automobil)
        {
            MvcOglasContext oglasContext = new MvcOglasContext();

            oglasContext.Automobil.Update(automobil);

            oglasContext.SaveChanges();
        }
    }
}

