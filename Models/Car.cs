using System;
using System.Collections.Generic;

namespace CarsWebAPI.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Yyear { get; set; }
        public string Country { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
    }
}
