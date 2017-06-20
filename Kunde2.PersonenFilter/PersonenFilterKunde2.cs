using System;
using System.Collections.Generic;
using System.Linq;
using PersonLibrary;

namespace Kunde2.PersonenFilter
{
    public class PersonenFilterKunde2
    {
        public List<Predicate<Person>> GetList()
        {
            var liste = new List<Predicate<Person>>();

            var umlaute = new char[] { 'ö', 'ü', 'ä' };
            liste.Add(new Predicate<Person>((p) => p.Alter > 25));
            liste.Add(new Predicate<Person>((p) => p.BewerberVorname.Equals("Carsten")));
            liste.Add(new Predicate<Person>((p) => p.BewerberVorname.ToLower().ToCharArray().Intersect(umlaute).Any()));
            return liste;
        }
    }
}