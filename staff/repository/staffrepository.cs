﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data.SqlClient;

using staff.model;
using staff.business;

namespace staff.repository
{
 public class staffregisterinfo
    { 

                public readonly string connectionstring;



    public staffregisterinfo()
    {
        connectionstring = @"Data source=DESKTOP-531QTCP;Initial catalog=staff;User Id=sa;Password=Anaiyaan@123";
    }

    public staffmodel data()
        {
            staffmodel emp = new staffmodel();

            Console.WriteLine("enter staff name");
            emp.NAME = Console.ReadLine();
            Console.WriteLine("enter lastname");
            emp.LASTNAME = Console.ReadLine();
            Console.WriteLine("enter phonenumber ");
            emp.PHONENUMBER = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter adders");
            emp.ADDERS = Console.ReadLine();

            return emp;
        }



        public void insertsp(staffmodel emp)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionstring);

                con.Open();
                con.Execute($"  exec insertstaff '{emp.NAME}','{emp.LASTNAME}','{emp.PHONENUMBER}','{emp.ADDERS}'");
                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<staffmodel> read()
        {
            try
            {
                List<staffmodel> constrain = new List<staffmodel>();

                var connection = new SqlConnection(connectionstring);
                connection.Open();
                constrain = connection.Query<staffmodel>("select *from staff").ToList();
                connection.Close();
                foreach (var cons in constrain)
                {
                    Console.WriteLine($"ID-->{cons.ID}\tname-->{cons.NAME}\tlastname-->{cons.LASTNAME}\tphonenumber-->{cons.PHONENUMBER}\tadders-->{cons.ADDERS}");

                }

                return constrain;


            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }

}