using System.Collections.Generic;

namespace Using_Delegate
{
    class AnotherCustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer firstCustomer, Customer secondCustomer)
        {
            int comparisonResult;
            if (((firstCustomer.ID > secondCustomer.ID) || ((secondCustomer == null) && (firstCustomer != null))))
            {
                comparisonResult = 1;
            }
            else if (((firstCustomer.ID < secondCustomer.ID) || ((secondCustomer != null) && (firstCustomer == null))))
            {
                comparisonResult = -1;
            }
            else
            {
                comparisonResult = 0;
            }
            return comparisonResult;
        }
    }
}

