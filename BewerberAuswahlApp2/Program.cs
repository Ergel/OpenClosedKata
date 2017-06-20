using System.Linq;
using Kunde2.PersonenFilter;
using PersonLibrary;

namespace Kunde2.BewerberAuswahl.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bewerberDateiPfad = System.Configuration.ConfigurationManager.AppSettings["BewerberDatei"];
            var listeDerBewerber = BewerberProvider.HoleListeDerBewerber(bewerberDateiPfad);
            foreach (var person in listeDerBewerber)
            {
                var kunde2 = new PersonenFilterKunde2();
                var liste = kunde2.GetList();
                if (Entscheider.IstAngenommen(liste, person))
                {
                    person.SendMail();
                }
            }
        }
    }
}
