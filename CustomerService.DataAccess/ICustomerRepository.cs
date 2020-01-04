using CustomerService.Model;
using Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerService.DataAccess
{
    public interface ICustomerRepository : IRepositoryManager<CustomerModel>
    {
    }
}
