using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonLibrary
{
    public class Entscheider
    {
        public static bool IstAngenommen(List<Predicate<Person>> personFilterListe, Person person)
        {
            foreach (var predicate in personFilterListe)
            {
                if (predicate.Invoke(person) == true)
                {
                    return false;
                }
            }

            ////var umlaute = new char[] { 'ö', 'ü', 'ä' };
            ////if (person.BewerberVorname.ToLower().ToCharArray().Intersect(umlaute).Any()
            ////    || person.Alter > 38)
            ////{
            ////    return false;
            ////}

            return true;
        }
    }
}