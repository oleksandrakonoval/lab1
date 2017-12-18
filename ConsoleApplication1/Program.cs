using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile MyMobile = new MobilePhone.SimCorpMobile();
            Console.WriteLine(MyMobile.Description());
            Console.ReadKey();
        }
    }
}
