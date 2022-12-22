using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class RoutesManager
    {
        public List<Route> routeList { get; set; }
        /// <summary>
        /// Basic constructor
        /// </summary>
        public RoutesManager()
        {
            routeList = new();
        }
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="r">route list</param>
        public RoutesManager(List<Route> r)
        {
            routeList = new();
            for (int i = 0; i < r.Count; i++)
            {
                routeList.Add(
                    new Route(
                        r[i].from,
                        r[i].to,
                        r[i].price,
                        r[i].transportationType,
                        r[i].minutes
                        )
                    );
            }
        }
        /// <summary>
        /// Method to retrieve route list
        /// </summary>
        public List<Route> GetRouteList()
        {
            return routeList;
        }
        /// <summary>
        /// Method to get the route at i index from list
        /// </summary>
        /// <param name="i">index</param>
        public Route GetRoute(int i)
        {
            return routeList[i];
        }
        /// <summary>
        /// Method to add a route to the list
        /// </summary>
        /// <param name="r">Route to be added</param>
        public void AddRoute(Route r)
        {
            routeList.Add(r);
        }
        /// <summary>
        /// Method to remove a route from the list
        /// </summary>
        /// <param name="index">Route index to be removed</param>
        public void RemoveRoute(int index)
        {
            routeList.RemoveAt(index);
        }
        /// <summary>
        /// Method to swap a Route to the list
        /// </summary>
        /// <param name="r">Route to be added</param>
        /// <param name="index">Index to be swapped</param>
        public void ChangeRoute(Route r, int index)
        {
            routeList[index].from = r.from;
            routeList[index].to = r.to;
            routeList[index].price = r.price;
            routeList[index].transportationType = r.transportationType;
        }
        /// <summary>
        /// Method to stringify all content
        /// </summary>
        public string GetStringList()
        {
            string s = "";
            for (int i = 0; i < routeList.Count; i++)
            {
                s += "From " + routeList[i].from + "\n";
                s += "To " + routeList[i].to + "\n";
                s += "Price " + routeList[i].price.ToString() + "\n";
                s += "Transportation "+routeList[i].transportationType.ToString() + "\n\n";
            }
            return s;
        }
        /// <summary>
        /// Method to return all transportation types used
        /// </summary>
        public List<TransportationTypes> GetTransportationTypesList()
        {
            List<TransportationTypes> result = new();
            for (int i = 0; i < routeList.Count; i++)
            {
                result.Add(routeList[i].transportationType);
            }
            return result;
        }
    }
}
