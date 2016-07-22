using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1_Yariv_Bracha
{
    class Man
    {
        public Man()
        {
            Id = 2;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id - {0}\n", Id);
            sb.AppendFormat("Name - {0}\n", Name);
            sb.AppendFormat("Adress - {0}\n", Adress);
            sb.AppendFormat("Weight - {0}\n", Weight);
            return sb.ToString();
        }
    }
}
