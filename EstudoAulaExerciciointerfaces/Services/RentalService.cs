﻿using EstudoAulaExerciciointerfaces.Entities;
using System.Security.Cryptography.X509Certificates;

namespace EstudoAulaExerciciointerfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;
        public RentalService(double pricePerHour, double pricePerDay,ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {

                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);//o math.ceiling arrendonda o número para cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _TaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }


    }
}