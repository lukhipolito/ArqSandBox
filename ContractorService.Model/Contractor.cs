using AccountService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractorService.Model
{
    public class Contractor
    {
        public Contractor()
        {
            SetRating();
        }

        /// <summary>
        /// Sets the rating for the contractor based on all his done services
        /// </summary>
        private void SetRating()
        {
            IList<double> scores = new List<double>();
            //Implement data base and query accross all services provided by this contractor, get all the scores and populate the list
            this.Rate(scores.Average());
        }

        /// <summary>
        /// Name of physical or juridical person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Score attribute for manipulation of rating
        /// </summary>
        internal protected double Score { get; set; }

        /// <summary>
        /// Rating attribute for presentation of the contractor
        /// </summary>
        public decimal Rating
        {
            get
            {
                if (this.Score >= 0 && this.Score <= 5)
                    return Convert.ToDecimal(this.Score);
                return 0M;
            }
        }

        /// <summary>
        /// Account details for payment
        /// </summary>
        public Account Account { get; set; }
    }
}
