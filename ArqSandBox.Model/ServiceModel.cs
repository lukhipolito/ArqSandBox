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
    }
}
