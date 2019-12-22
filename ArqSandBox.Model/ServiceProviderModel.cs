using System;
using System.Collections.Generic;
using System.Text;

namespace ArqSandBox.Model
{
    public class ServiceProviderModel
    {
        public string Name { get; set; }

        protected double Score { get; set; }

        public decimal Rating
        {
            get
            {
                if (this.Score >= 0 && this.Score <= 5)
                    return Convert.ToDecimal(this.Score);
                return 0M;
            }
        }
    }
}
