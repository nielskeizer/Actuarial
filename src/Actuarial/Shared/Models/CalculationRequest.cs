using System;
using System.Collections.Generic;
using Shared.Domain;

namespace Shared.Models
{
    public class CalculationRequest
    {
        public ProductType ProductType { get; set; }
        public IEnumerable<Person> Persons { get; set; }
        public decimal InsuredAmount { get; set; }
        public int Duration { get; set; }
        public int Deferred { get; set; }
        public DateTime CalculationDate { get; set; }
        public double Interest { get; set; }
    }
}