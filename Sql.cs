﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Workers
{
    interface INpgsql
    {
        void Connected(IRequest request);

    }
    interface IRequest
    {
        string Request();
    }
    public class Select_All : IRequest
    {
        public string Request()
        {
            string request = $"SELECT * FROM {Console.ReadLine()}";
            return request;
        }
    }
    public class Delete : IRequest
    {

        public string Request()
        {
            string request = $"SELECT * FROM {Console.ReadLine()}";
            return request;
        }
    }
    public class Insert : IRequest
    {
        public string Request()
        {
            string request = "INSERT INTO department (department_id, department_parent_id ) VALUES (3, 0)";
            return request;
        }
    }

    internal class Sql:INpgsql
    {
        public void Connected(IRequest request)
        { 
            string str = string.Empty;

            string connString = "Host=localhost;Username=postgres;Password=VeNtRu72;Database=workers";
              var con = new NpgsqlConnection(connString);
            con.Open();
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;
             cmd.CommandText = "INSERT INTO department (department_id, department_parent_id ) VALUES (5, 0)";
            cmd.ExecuteNonQuery();

            
            

            //npgc.ExecuteNonQuery();

            con.Close();
        }


        //public void Connected(IRequest request)
        //{   string str = string.Empty;

        //    string connString = "Host=localhost;Username=postgres;Password=VeNtRu72;Database=workers";
        //    NpgsqlConnection nc = new NpgsqlConnection(connString);

        //    nc.Open();
        //    NpgsqlCommand npgc = new NpgsqlCommand(request.Request(), nc);

        //    //npgc.ExecuteNonQuery();
        //    if (request.GetType() == new Select_All().GetType())
        //    {
        //        List<Department> list = new List<Department>();
        //    using(var reader = npgc.ExecuteReader())
        //        {
        //            while(reader.Read())
        //            {
        //                //Console.WriteLine("{0} {1} ", reader.GetInt32(0), reader.GetInt32(1));
        //                Department department = new Department();
        //                department.Depatment_id= reader.GetInt32(0);
        //                department.Depatment_parent_id = reader.GetInt32(1);
        //                list.Add(department);
        //            }
        //        }
        //     foreach(Department item in list)
        //        {
        //            item.Print();
        //        }
        //        Console.ReadKey();
        //    }
        //    nc.Close();
        //}
    }
}
