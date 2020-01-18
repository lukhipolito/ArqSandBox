using System;
using System.Collections.Generic;
using System.Text;

namespace AccountService.Model
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public Bank Bank { get; set; }

        //public type - ENUM
    }
}
