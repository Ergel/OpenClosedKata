using System;
using System.Collections.Generic;
using System.Linq;
using PersonLibrary;

namespace Kunde1.PersonenFilter
{
    public class PersonenFilterKunde1 : IPersonenFilter
    {

        public List<Predicate<Person>> GetList()
        {
            var liste = new List<Predicate<Person>>();

            var umlaute = new char[] { 'ö', 'ü', 'ä' };
            liste.Add(new Predicate<Person>((p) => p.Alter > 38));
            liste.Add(new Predicate<Person>((p) => p.BewerberVorname.ToLower().ToCharArray().Intersect(umlaute).Any()));
            liste.Add(new Predicate<Person>((p) => p.BewerberVorname.StartsWith("Do")));
            liste.Add(new Predicate<Person>((p) => p.BewerberVorname.StartsWith("Re")));
            return liste;
        }




    }
}
