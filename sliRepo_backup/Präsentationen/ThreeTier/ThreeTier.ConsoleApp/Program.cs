﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThreeTier.Service;
using ThreeTier.Service.DemoServices;
using ThreeTier.Data;
namespace ThreeTier.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Great Social Community System - Please Login...");
            Console.Write("Name: ");
            string loginname = Console.ReadLine();
            Console.Write("PW: ");
            string password = Console.ReadLine();

            IUserService srv = new DemoUserService();
            User loginUser = new User();
            loginUser.Login = loginname;
            loginUser.Password = password;

            if (srv.Login(loginUser))
            {
                Console.WriteLine("Hello: " + loginname);
                Console.WriteLine("Your demo friend collection in the system: ");
                List<User> friends = srv.GetFriendsFromUser(loginUser).ToList();

                foreach (User friend in friends)
                {
                    Console.WriteLine(" + " + friend.Login + " - Id: " + friend.Id);
                }
            }
            else
            {
                Console.WriteLine("Login failed");
            }

            Console.ReadLine();
        }

    }
}
