using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Route
    {
        public string from { get; set; } = string.Empty;
        public string to { get; set; } = string.Empty;
        public double price { get; set; } = 0;
        public int minutes { get; set; } = 0;
        public TransportationTypes transportationType { get; set; }
        public Route() { }
        public Route(string from, string to, double price, TransportationTypes transportationType, int minutes) {
            this.from = from;
            this.to = to;
            this.price = price;
            this.transportationType = transportationType;
            this.minutes = minutes;
        }
    }
}
