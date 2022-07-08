using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Workers
{
    interface IWorkers
    {
         
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Sql_Command sql_Command = new Sql_Command();
            sql_Command.Connected(sql_Command.Insert_Department());
            
            Sql sql = new Sql();
            //sql.Connected(new Select_All());
            
            //sql.Connected(new Insert());
        }
    }
}
