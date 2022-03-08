using System.Collections.Generic;

namespace Paymentsense.Coding.Challenge.Api.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Population { get; set; }
        public string Alpha3Code { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public IEnumerable<Language> Language { get; set; }
        public IEnumerable<Currency> Currency { get; set; }
    }
}