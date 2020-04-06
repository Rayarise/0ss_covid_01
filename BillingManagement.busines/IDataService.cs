using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.busines
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
