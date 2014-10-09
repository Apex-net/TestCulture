using System;
using System.ComponentModel.DataAnnotations;

namespace TestCulture.Models
{
    public class TestClass
    {
        public DateTime CreatedAt { get; set; }

        [Range(10.5D, 20.3D)]
        public decimal Amount { get; set; }

        public string Culture { get; set; }
    }
}