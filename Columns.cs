using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class Columns
    {
        public int Worker_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Type_Worker { get; set; }
        public int Salary_id { get; set; }
        public int Salary { get; set; }
        public int Depatment_id { get; set; }
        public int Depatment_parent_id { get; set; }
        public Columns() { }
        public Columns(int Depatment_id, int Depatment_parent_id)
        {
            this.Depatment_id = Depatment_id;
            this.Depatment_parent_id = Depatment_parent_id;
        }

    }
    class Department  
    {
        public int Depatment_id { get; set; }
        public int Depatment_parent_id { get; set; }
        public Department(){}
        public Department(int Depatment_id, int Depatment_parent_id)
        {
        this.Depatment_id = Depatment_id;
        this.Depatment_parent_id = Depatment_parent_id;      
        }
        public void Print()
        {
            Console.WriteLine($"Depatment_id {Depatment_id} Depatment_parent_id {Depatment_parent_id}");
        }
    }

}
