using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Contracts
{
    interface IFlyable
    {
        string FlySpeed { get; set; }
        
        string Fly();
    }
}
