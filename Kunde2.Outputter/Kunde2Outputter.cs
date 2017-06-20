using PersonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde2.Outputter
{
    public class Kunde2Outputter : IOutPutter
    {
        public void OutPutResult(bool wurdeAngenommen, Person person)
        {
            if (wurdeAngenommen)
            {
                Console.WriteLine("{0} kann hier arbeiten!", person.BewerberVorname);
            }
            else
            {
                Console.WriteLine("{0} kann hier nicht arbeiten!", person.BewerberVorname);
            }
        }
    }
}
