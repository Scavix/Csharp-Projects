using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Task
    {
        public string description { get; set; } = string.Empty;
        public PriorityType priority { get; set; } = PriorityType.Normal;
        public DateTime dateTime { get; set; } = DateTime.Now;
        public Task()
        {

        }
        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="d">description</param>
        /// <param name="pt">priority</param>
        /// <param name="dt">dateTime</param>
        public Task(string d, PriorityType pt, DateTime dt)
        {
            description = d;
            priority = pt;
            dateTime = dt;
        }
    }
}
