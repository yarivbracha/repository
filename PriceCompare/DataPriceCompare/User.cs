using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPriceCompare
{
    public class User
    {
        private const string path = @"C:\Users\yariv\Source\Repos\repository\PriceCompare\DataPriceCompare\ShoppingCarts";

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
            FIleName = sb.ToString();
            File.CreateText(FIleName);
        }
        public long ID { get; private set; }

        public string Name { get; private set; }

        public string Password { get; private set; }

        public string FIleName { get; private set; }
    }
}
