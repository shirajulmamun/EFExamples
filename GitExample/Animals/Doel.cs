using GitExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Animals
{
    class Doel:Animal,IFlyable
    {
        public string FlySpeed
        {
            get;set;
        }

        public override string Speak()
        {
            return "Doel is Speaking!";
        }
        public string Fly()
        {
            return "Doel is flying!";
        }
    }
}
