﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Animals
{
    public abstract class Animal
    {
        public abstract string Speak();
        

        public virtual string Move()
        {
            return "Animal is moving";
            
        }

        public string Eat()
        {
            return "Animal is eating!";
        }

        

    }
}
