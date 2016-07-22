using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1_Yariv_Bracha
{
    class Woman
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; private set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id - {0}\n", Id);
            sb.AppendFormat("Name - {0}\n", Name);
            sb.AppendFormat("Height - {0}\n", Height);
            sb.AppendFormat("Weight - {0}\n", Weight);
            return sb.ToString();
        }

    }
}
