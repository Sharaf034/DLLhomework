﻿//using Domain.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Service.Services
//{
//    internal class AccountServise
//    {
//        public bool Login(string username, string password)
//        {
//            var dbUsers = GetUsers();
//            foreach (User user in dbUsers)
//            {
//                if (user.Username == username && user.Password == password)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private User[] GetUsers()
//        {
//            User[] users =
//            {
//                new User
//                {
//                    Id = 1,
//                    Username = "ismayil55",
//                    Password = "ismayil123",
//                },

//                 new User
//                {
//                    Id = 2,
//                    Username = "xeyyam55",
//                    Password = "xeyyam123",
//                },

//                  new User
//                {
//                    Id = 3,
//                    Username = "pervin55",
//                    Password = "pervin123",
//                }
//            };
//        }
//    }
//}
