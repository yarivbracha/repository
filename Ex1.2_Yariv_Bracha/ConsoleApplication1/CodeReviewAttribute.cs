using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]

    public sealed class CodeReviewAttribute : Attribute
    {
        private string reveiwerName;
        private DateTime reviewDate;
        private bool isApproved;

        public CodeReviewAttribute(string name, string date, bool approved)
        {
            this.reveiwerName = name;
            this.reviewDate = DateTime.Parse(date);
            this.isApproved = approved;

        }

        public string ReviewerName
        {
            get
            {
                return reveiwerName;
            }
        }

        public DateTime ReviewDate
        {
            get
            {
                return reviewDate;
            }
        }

        public bool IsApproved
        {
            get
            {
                return isApproved;
            }
        }
    }
}
