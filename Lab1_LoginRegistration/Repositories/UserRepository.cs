﻿using Lab1_LoginRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_LoginRegistration.Repositories
{
    internal static class UserRepository
    {
        public static List<User> users = new List<User>();

        public static List<User> getUsers()
        {
            return users;
        }
    }
}
