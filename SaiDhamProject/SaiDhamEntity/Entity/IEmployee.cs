using System;
using System.Collections.Generic;
using System.Text;

namespace SaiDhamEntity.Entity
{
    public class IEmployee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MidleName { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public double Salary { get; set; }
    }
}
