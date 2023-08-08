using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data.SqlClient;

using staff.model;
using staff.repository;

namespace staff.business
{
    public class staffbusiness
    {

        int a;

   


        public void doit()
        {

            staffregisterinfo obj = new staffregisterinfo();
            do
            {
                Console.WriteLine("choose the option");
                Console.WriteLine("0.exit");
                Console.WriteLine("1.list");
                Console.WriteLine("2.insert");



                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 0:
                        Console.WriteLine("exiting");
                        break;

                    case 1:
                        obj.selectsp();

                        break;

                    case 2:
                        var staffmodel = obj.data();
                        obj.insertsp(staffmodel);
                        break;

                    default:
                        Console.WriteLine("valid option");
                        break;
                }
            } while (a != 0);

        }
    }
}



