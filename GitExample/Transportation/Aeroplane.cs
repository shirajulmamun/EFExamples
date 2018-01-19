using GitExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Transportation
{
    class Aeroplane : IFlyable
    {
        public string FlySpeed
        {
            get;set;
        }

        public string Fly()
        {
            return "Aeroplane is flying!";
        }
    }
}
