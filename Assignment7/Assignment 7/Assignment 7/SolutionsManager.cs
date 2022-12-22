using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class SolutionsManager
    {
        public List<Solution> solutions { get; set; }
        public Preference preference { get; set; }
        public SolutionsManager()
        {
            solutions = new();
            preference = new();
        }
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="s">solutions list</param>
        public SolutionsManager(List<Solution> s, Preference p)
        {
            solutions = new();
            for (int i = 0; i < s.Count; i++)
            {
                solutions.Add(s[i]);
                solutions[i].TotalPrice = solutions[i].Price * p.Adults + solutions[i].Price * p.Children / 2;
            }
            for (int i = 0; i < solutions.Count; i++)
            {
                if (solutions[i].Rm.GetRouteList().Count == 1)
                {
                    solutions[i].TotalMinutes = solutions[i].Rm.GetRoute(0).minutes;
                }
                else if (solutions[i].Rm.GetRouteList().Count == 2)
                {
                    solutions[i].TotalMinutes = solutions[i].Rm.GetRoute(0).minutes + solutions[i].Rm.GetRoute(1).minutes;
                }
                else
                {
                    solutions[i].TotalMinutes = solutions[i].Rm.GetRoute(0).minutes + solutions[i].Rm.GetRoute(1).minutes + solutions[i].Rm.GetRoute(2).minutes;
                }
            }
            preference = p;
            Filter();
        }
        /// <summary>
        /// Method to retrieve solutions list
        /// </summary>
        public List<Solution> GetSolutionsList()
        {
            return solutions;
        }
        /// <summary>
        /// Method to get the solution at i index from list
        /// </summary>
        /// <param name="i">index</param>
        public Solution GetSolution(int i)
        {
            return solutions[i];
        }
        /// <summary>
        /// Method to add a solution to the list
        /// </summary>
        /// <param name="c">Solution to be added</param>
        public void AddSolution(Solution s)
        {
            s.TotalPrice = s.Price * preference.Adults + s.Price * preference.Children / 2;
            solutions.Add(s);
            Filter();
        }
        /// <summary>
        /// Method to remove a solution from the list
        /// </summary>
        /// <param name="index">Solution index to be removed</param>
        public void RemoveCity(int index)
        {
            solutions.RemoveAt(index);
        }
        /// <summary>
        /// Method to swap a Solution to the list
        /// </summary>
        /// <param name="s">Solution to be added</param>
        /// <param name="index">Index to be swapped</param>
        public void ChangeCity(Solution s, int index)
        {
            solutions[index] = s;
        }
        /// <summary>
        /// Method to filter based on preferences
        /// </summary>
        public void Filter()
        {
            List<Solution> list = new();
            bool flag;
            for (int i = 0; i < solutions.Count; i++)
            {
                flag = false;
                /// Check if we want only directs
                if (solutions[i].Rm.GetRouteList().Count != 1 && preference.Direct)
                {
                    flag = true;
                }
                /// Remove directs in case
                if (solutions[i].Rm.GetRouteList().Count == 1 && (!preference.Direct))
                {
                    flag = true;
                }
                /// Check the price caps
                if (preference.PriceMax != 0)
                {
                    if (solutions[i].TotalPrice > preference.PriceMax)
                    {
                        flag = true;
                    }
                }
                /// Check the time  caps
                if (preference.TimeMax != 0)
                {
                    if (solutions[i].TotalMinutes > preference.TimeMax)
                    {
                        flag = true;
                    }
                }
                /// Check the trasportation filter
                for (int j = 0; j < solutions[i].Rm.GetTransportationTypesList().Count; j++)
                {
                    if (!preference.TransportationTypesList.Contains(solutions[i].Rm.GetTransportationTypesList()[j]))
                    {
                        flag = true;
                    }
                }
                /// Check for dumb path, with repetion. E.g. London -> Dublin -> London -> Brussels
                if (solutions[i].Rm.GetRouteList().Count == 3)
                {
                    for (int j = 0; j < solutions[i].Rm.GetRouteList().Count; j++)
                    {
                        if ((solutions[i].From == solutions[i].Rm.GetRoute(1).from)
                            ||
                            (solutions[i].From == solutions[i].Rm.GetRoute(1).to)
                            ||
                            (solutions[i].To == solutions[i].Rm.GetRoute(1).from)
                            ||
                            (solutions[i].To == solutions[i].Rm.GetRoute(1).to))
                        {
                            flag = true;
                        }
                    }
                }
                if (!flag)
                {
                    list.Add(solutions[i]);
                }
            }
            solutions = new();
            for (int i = 0; i < list.Count; i++)
            {
                solutions.Add(list[i]);
            }
        }
    }
}
