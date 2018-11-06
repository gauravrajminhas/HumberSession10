using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using humber.com;

namespace Session10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Class1> listObject = new List<Class1>();
            
            listObject.Add(new Class1());
            listObject.Add(new Class1());

            foreach (var x in listObject)
            {
                System.Console.WriteLine("objects :-  {0}",x);
            }

            System.Console.ReadLine();
        }
    }

 




}
