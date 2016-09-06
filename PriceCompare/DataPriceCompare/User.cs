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
            FileName = sb.ToString();
            File.CreateText(FileName);
        }
        public long Id { get; private set; }

        public string Name { get; private set; }

        public string Password { get; private set; }

        public string FileName { get; private set; }
    }
}
