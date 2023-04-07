using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            polymorphism poly = new polymorphism();
            poly.WhoAmI();
            poly.WhoAmI("azay");
            poly.WhoAmI(5);




            Tiger tiger = new Tiger();
            tiger.WhatIeat();
            tiger.WhatIbreathe();

            //Lion lion = new Lion();
           
            //lion.WhatIeat();
            //.WhatIbreathe();
            try
            {
                string[] name = new string[5];
                name[0] = "Ramesh";
                name[5] = "Dinesh";
                string myNumber = Console.ReadLine();
                int rollName = Convert.ToInt32(myNumber);
                Console.WriteLine(rollName);
            } catch (Exception ex )
            { Console.WriteLine("Exception occurs of try" +ex.Message);
            }

            Console.ReadKey();
        }
    }
}
