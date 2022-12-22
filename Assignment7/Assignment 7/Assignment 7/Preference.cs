using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Preference
    {
        public int TimeMax { get; set; }
        public double PriceMax { get; set; }
        public bool Direct { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public List<TransportationTypes> TransportationTypesList { get; set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Preference()
        {
            TimeMax = 0;
            PriceMax= 0;
            Direct = true;
            Adults = 1;
            Children = 0;
            TransportationTypesList = new();
        }
        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="timeMax"></param>
        /// <param name="priceMax"></param>
        /// <param name="direct"></param>
        /// <param name="adults"></param>
        /// <param name="children"></param>
        /// <param name="transportationTypesList"></param>
        public Preference(int timeMax, double priceMax, bool direct, int adults, int children, List<TransportationTypes> transportationTypesList)
        {
            TimeMax = timeMax;
            PriceMax = priceMax;
            Direct = direct;
            Adults = adults;
            Children = children;
            TransportationTypesList = new();
            for (int i = 0; i<transportationTypesList.Count; i++)
            {
                TransportationTypesList.Add(transportationTypesList[i]);
            }
        }
    }
}
