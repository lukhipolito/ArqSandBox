using ArqSandBox.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArqSandBox.Model
{
    public class PaymentModel
    {
        public double Total { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
    }
}
