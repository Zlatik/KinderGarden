using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarden
{
    interface IHuman
    {
         int Age { get; set; }
         string Name { get; set; }
         string Surname { get; set; }
         string Address { get; set; }
         string Father { get; set; }
         string Mother { get; set; }
    }
}
