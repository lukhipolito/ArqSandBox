using Arq.Commom;
using PaymentService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.DataAccess
{
    public interface IPaymentRepository : IRepositoryManager<Payment>
    {
    }
}
