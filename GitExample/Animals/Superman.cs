using GitExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Animals
{
    public class Superman : Animal, IFlyable, IEquatable<Superman>,IEqualityComparer<Superman>
    {
        public string FlySpeed
        {
            get;set;
        }

        public bool Equals(Superman other)
        {
           return other.FlySpeed.Equals(FlySpeed);
        }

        public bool Equals(Superman x, Superman y)
        {
            return x.FlySpeed.Equals(y.FlySpeed);
        }

        public string Fly()
        {
            return "Super Man is flying!";
        }

        public int GetHashCode(Superman obj)
        {
            throw new NotImplementedException();
        }

        public override string Speak()
        {
            return "Superman is Speaking!";
        }
    }
}
