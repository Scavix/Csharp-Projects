using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class SearchManager
    {
        /// <summary>
        /// Main Algorithms method to return solutions given preferences
        /// </summary>
        /// <param name="preference"></param>
        /// <returns>List of Solutions of Path</returns>
        public static List<Solution> SearchRoutes(List<Route> routes, string cityFrom, string cityTo)
        {
            List<Solution> results = new();
            RoutesManager routesManager = new(routes);
            List<Route> routesResult;
            ///maximum depth of the search is 3
            ///Routes are in one direction
            ///for each route
            for (int i = 0; i < routesManager.GetRouteList().Count; i++)
            {
                ///if we find a direct one
                if (routesManager.GetRoute(i).from.Equals(cityFrom) && routesManager.GetRoute(i).to.Equals(cityTo))
                {
                    routesResult = new()
                    {
                        routesManager.GetRoute(i)
                    };
                    results.Add(new Solution(routesResult,cityFrom,cityTo));
                }
            }
            ///else we go for more depth
            ///for each route
            for (int i = 0; i < routesManager.GetRouteList().Count; i++)
            {
                if (routesManager.GetRoute(i).from.Equals(cityFrom))
                {
                    for (int j = 0; j < routesManager.GetRouteList().Count; j++)
                    {
                        //if we find a non direct one with depth 2
                        if ((routesManager.GetRoute(i).to.Equals(routesManager.GetRoute(j).from)) && (routesManager.GetRoute(j).to.Equals(cityTo)))
                        {
                            routesResult = new()
                            {
                                routesManager.GetRoute(i),
                                routesManager.GetRoute(j)
                            };
                            results.Add(new Solution(routesResult,cityFrom,cityTo));
                        }
                    }
                }
            }
            ///else we go for more depth
            ///for each route
            for (int i = 0; i < routesManager.GetRouteList().Count; i++)
            {
                if (routesManager.GetRoute(i).from.Equals(cityFrom))
                {
                    for (int j = 0; j < routesManager.GetRouteList().Count; j++)
                    {
                        if (routesManager.GetRoute(i).to.Equals(routesManager.GetRoute(j).from))
                        {
                            for (int k = 0; k < routesManager.GetRouteList().Count; k++)
                            {
                                //if we find a non direct one with depth 3
                                if ((routesManager.GetRoute(j).to.Equals(routesManager.GetRoute(k).from)) && (routesManager.GetRoute(k).to.Equals(cityTo)))
                                {
                                    routesResult = new()
                                    {
                                        routesManager.GetRoute(i),
                                        routesManager.GetRoute(j),
                                        routesManager.GetRoute(k)
                                    };
                                    results.Add(new Solution(routesResult, cityFrom, cityTo));
                                }
                            }
                        }
                    }
                }
            }
            return results;
        }
    }
}
