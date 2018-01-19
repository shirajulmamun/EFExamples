using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample.Animals
{
    class People : IEnumerable<Person>
    {
        public IEnumerator<Person> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class PersonEnumerator : IEnumerator<Person>
    {
        public Person Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
