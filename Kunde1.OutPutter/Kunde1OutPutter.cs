using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace Kunde1.OutPutter
{
    public class Kunde1OutPutter : IOutPutter
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
