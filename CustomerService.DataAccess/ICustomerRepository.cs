using Arq.Commom;
using CustomerService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerService.DataAccess
{
    public interface ICustomerRepository : IRepositoryManager<Customer>
    {
    }
}
