using GitExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Animals
{
    class Eagle:Animal,IFlyable
    {
        public string FlySpeed
        {
            get;set;
        }

        public override string Speak()
        {
            return "Eagle is speaking!";
        }
        public string Fly()
        {
            return "Eagle is flying!";
        }

    }
}
