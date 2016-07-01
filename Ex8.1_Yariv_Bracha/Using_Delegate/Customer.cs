using System;
using System.Text;


namespace Using_Delegate
{
    class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        private string name;
        private int id;
        private string adress;

        public Customer(string name, int id, string adress)
        {
            this.name = name;
            this.id = id;
            this.adress = adress;
        }

        public string Name
        {
            get { return name; }
        }

        public int ID
        {
            get { return id; }
        }

        public string Adress
        {
            get { return adress; }
        }

        public int CompareTo(Customer other)
        {
            int returnCompareValue;
            if (this.Name != null)
            {
                if ((other == null) || (other.Name == null))
                {
                    returnCompareValue = 1;
                }
                else
                {
                    returnCompareValue = this.Name.CompareTo(other.Name);
                }
            }
            else 
            {
                if ((other == null) || (other.Name == null))
                {
                    returnCompareValue = 0;
                }
                else
                {
                    returnCompareValue = -1;
                }
            }
            return returnCompareValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name - {0}, ID - {1}, Adress - {2}", this.Name, this.ID, this.Adress);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            bool isEquals = false;
            if (other == null)
            {
                isEquals = false;
            }
            else if ((this.Name.Equals(other.Name)) && (this.ID == other.ID))
            {
                isEquals = true;
            }
            return isEquals;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + ID.GetHashCode();
        }
    }
}

