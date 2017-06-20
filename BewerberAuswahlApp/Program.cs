using System;
using System.Reflection;
using PersonLibrary;

namespace Kunde1.BewerberAuswahl.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bewerberDateiPfad = System.Configuration.ConfigurationManager.AppSettings["BewerberDatei"];
            var listeDerBewerber = BewerberProvider.HoleListeDerBewerber(bewerberDateiPfad);
            foreach (var person in listeDerBewerber)
            {
                var kunde1 = HoleAlleFilter();
                var liste = kunde1.GetList();
                var istAngenommen = Entscheider.IstAngenommen(liste, person);
                var outPutter = HoleOutPutter();
                outPutter.OutPutResult(istAngenommen, person);
            }

            Console.WriteLine("Bitte drücken Sie eine belibige Taste um die Anwendung zu beenden.");
            Console.ReadLine();
        }


        private static IPersonenFilter HoleAlleFilter()
        {
            var typeDerPersonenFilter = System.Configuration.ConfigurationManager.AppSettings["NameVonFilterKlasse"]; ;
            var nameVonModulDerPersonenFilter = System.Configuration.ConfigurationManager.AppSettings["NameVonFilterModule"];

            var assembly = Assembly.Load(nameVonModulDerPersonenFilter);
            var typeDerFilter = assembly.GetType(typeDerPersonenFilter);

            var filterInstanz = Activator.CreateInstance(typeDerFilter);
            return filterInstanz as IPersonenFilter;
        }

        private static IOutPutter HoleOutPutter()
        {
            var nameDerOutPutter = System.Configuration.ConfigurationManager.AppSettings["NameVonOutPutterKlasse"];
            var nameVonModulDerOutPutter = System.Configuration.ConfigurationManager.AppSettings["NameVonOutPutterModule"];

            var assembly = Assembly.Load(nameVonModulDerOutPutter);
            var typeDerOutPutter = assembly.GetType(nameDerOutPutter);

            var outPutterInstanz = Activator.CreateInstance(typeDerOutPutter);
            return outPutterInstanz as IOutPutter;
        }
    }


}
