using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meniu
    {
        List<Produs> _produse;

        Meniu()
        {
            _produse = new List<Produs>();
        }

        //de facut o lista statica de produse pentru ca vrem sa fie create doar o singura data pentru fiecare meniu ???
    }
}
