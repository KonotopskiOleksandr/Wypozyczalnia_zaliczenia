﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenia
{
    public class AllUsers
    {
        public AllUsers(int id, string firstName, string lastName, string time)
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
        public DateTime Test { get; set; }
    }
}
