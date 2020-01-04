using Manager;
using PaymentService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.DataAccess
{
    public interface IPaymentRepository : IRepositoryManager<PaymentModel>
    {
    }
}
