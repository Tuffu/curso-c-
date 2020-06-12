using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee()
        {

        }
        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public OutsorcedEmployee(string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
