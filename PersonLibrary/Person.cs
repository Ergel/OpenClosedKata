using System;

namespace PersonLibrary
{
    public class Person
    {
        public Person(int alter, string vorname)
        {
            Alter = alter;
            BewerberVorname = vorname;

        }

        public Person(int alter, string vorname, string emailAdresse) : this(alter, vorname)
        {
            MailAdresse = emailAdresse;

        }

        public int Alter { get; private set; }
        public string BewerberVorname { get; }
        public string MailAdresse { get; private set; }

        public void SendMail()
        {
            //TODO: Mail per SMTP schicken
            Console.WriteLine("Mail mit dem Betreff: \"Einladung zum Bewerbungsgespräch\" wurde an {0} geschickt.", MailAdresse);
        }


    }
}
