using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMovies2.Models
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public string Gender { get; set; }
        public decimal Age { get; set; }
        public string ManagerComment { get; set; }
        public bool ManagerAccept { get; set; }
       
    }
}