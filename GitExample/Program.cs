using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write("Student Add");
            if(student!=null)
            {
                Console.WriteLine("Student Exists");
            }
        }
    }
}
