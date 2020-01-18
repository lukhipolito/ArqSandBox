using ContractorService.Model;
using CustomerService.Model;
using PaymentService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContract.Model
{
    public class ServiceContract
    {
        /// <summary>
        /// Date of service start
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Date of service end
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Provider of the service
        /// </summary>
        public Contractor Provider { get; set; }

        /// <summary>
        /// The client who contracts the service
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Total value of service for presentation
        /// </summary>
        public double Total
        {
            get
            {
                return this.Payment != null ? this.Payment.Total : 0.0;
            }
        }

        /// <summary>
        /// Informations of the payment
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Commercial name of service provided
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Brief description of activities involved in the service provided
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Type of service
        /// </summary>
        public string ServiceType { get; set; }

        /// <summary>
        /// Rating attribute for manipulation
        /// </summary>
        public double Score { get; set; }
    }
}
