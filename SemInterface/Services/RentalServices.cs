using SemInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemInterface.Services
{
    class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalServices(double pricePerHour, double pricePerDay, ITaxService tax)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = _taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0){
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // math.ceiling arredonda para cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
