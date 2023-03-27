﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriverBasics.Entities
{
    public class User
    {
        private readonly string login;
        private readonly string password;

        public string[] DataUser { get; set; }

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
            DataUser = new[] { this.login, this.password };
        }
    }
}