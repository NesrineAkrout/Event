﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class User
    {
        public User() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public User(int id, string firstName, string lastName, string email)
        {

            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
