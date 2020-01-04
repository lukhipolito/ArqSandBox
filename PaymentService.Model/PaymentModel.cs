using PaymentService.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentService.Model
{
    public class PaymentModel
    {
        public double Total { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
    }
}
