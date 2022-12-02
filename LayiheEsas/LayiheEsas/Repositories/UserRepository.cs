﻿using LayiheEsas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayiheEsas.Repositories
{
    internal class UserRepository:IUserRepository
    {
        readonly Bank _bank;
        public Bank bank {get { return _bank;}}

        public UserRepository()
        {
            _bank = new Bank();         
        }

        public void UserRegistration(User user)
        {
            Array.Resize(ref bank.Users, bank.Users.Length + 1);
            bank.Users[bank.Users.Length - 1] = user;
        }

        public void UserLogin(User user) 
        {
            user.IsLogged = true;
            Console.WriteLine($"Name: {user.Name}; Surname: {user.Surname}");
        }

        public void FindUser(User user)
        {
            Console.WriteLine($"Name: {user.Name}; Surname: {user.Surname}");
        }
    }
}