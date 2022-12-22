using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Solution
    {
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public double TotalPrice { get; set; } = 0;
        public int TotalMinutes { get; set; } = 0;
        public RoutesManager Rm { get; set;} = new();
        /// <summary>
        /// Basic contructor
        /// </summary>
        public Solution() { }
        /// <summary>
        /// Basic contructor with one argument
        /// </summary>
        /// <param name="routesResult"></param>
        public Solution(List<Route> routesResult, string from, string to){
            Rm = new RoutesManager(routesResult);
            for (int i = 0; i < Rm.GetRouteList().Count; i++)
            {
                Price += Rm.GetRoute(i).price;
            }
            From = from;
            To = to;
        }
    }
}
