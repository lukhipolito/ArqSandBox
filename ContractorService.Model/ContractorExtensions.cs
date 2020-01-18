using System;
using System.Collections.Generic;
using System.Text;

namespace ContractorService.Model
{
    public static class ContractorExtensions
    {
        /// <summary>
        /// Rates the contractor
        /// </summary>
        /// <param name="contractor"></param>
        /// <param name="Grade"></param>
        internal static void Rate(this Contractor contractor, double Grade)
        {
            contractor.Score = Grade;
        }
    }
}
