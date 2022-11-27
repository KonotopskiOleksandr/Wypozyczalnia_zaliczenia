using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaZal
{
    internal class Clients
    {
        public Clients(int id, string firstName, string lastName, string time)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Time = time;
        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Time { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
