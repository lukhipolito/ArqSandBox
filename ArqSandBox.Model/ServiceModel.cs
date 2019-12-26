using System;
using System.Collections.Generic;
using System.Text;

namespace ArqSandBox.Model
{
    public class ServiceModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ServiceProviderModel Provider { get; set; }
        public CustomerModel Customer { get; set; }
        public double Total
        {
            get
            {
                return this.Payment != null ? this.Payment.Total : 0.0;
            }
        }
        public PaymentModel Payment { get; set; }
    }
}
