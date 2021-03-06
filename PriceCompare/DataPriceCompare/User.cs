﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class User : IDBItem
    {
        private const string path = "ShoppingCarts";

        public User()
        {

        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            CreateUserFile();
        }

        private void CreateUserFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(path);
            sb.Append(@"\");
            sb.Append(Name);
            sb.Append(".txt");
            FileName = sb.ToString();
            File.CreateText(FileName);
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Password { get; private set; }

        public string FileName { get; private set; }
    }
}
