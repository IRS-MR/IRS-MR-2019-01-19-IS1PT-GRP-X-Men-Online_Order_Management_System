﻿using System.ComponentModel.DataAnnotations;

namespace doremi.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        [Required]
        public string CurrencyName { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
    }
}
