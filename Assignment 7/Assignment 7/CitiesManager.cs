namespace Assignment_7
{
    public class CitiesManager
    {
        public List<string> cities { get; set; } = new();
        /// <summary>
        /// Basic constructor
        /// </summary>
        public CitiesManager() { }
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="c">cities list</param>
        public CitiesManager(List<string> c)
        {
            cities = new();
            for (int i = 0; i < c.Count; i++)
            {
                cities.Add(c[i]);
            }
        }
        /// <summary>
        /// Method to retrieve cities list
        /// </summary>
        public List<string> GetCitiesList()
        {
            return cities;
        }
        /// <summary>
        /// Method to get the city at i index from list
        /// </summary>
        /// <param name="i">index</param>
        public string GetCity(int i)
        {
            return cities[i];
        }
        /// <summary>
        /// Method to add a city to the list
        /// </summary>
        /// <param name="c">City to be added</param>
        public void AddCity(string c)
        {
            cities.Add(c);
        }
        /// <summary>
        /// Method to remove a city from the list
        /// </summary>
        /// <param name="index">City index to be removed</param>
        public void RemoveCity(int index)
        {
            cities.RemoveAt(index);
        }
        /// <summary>
        /// Method to swap a City to the list
        /// </summary>
        /// <param name="c">City to be added</param>
        /// <param name="index">Index to be swapped</param>
        public void ChangeCity(string c, int index)
        {
            cities[index] = c;
        }
        /// <summary>
        /// Clear cities list
        /// </summary>
        public void ClearCities()
        {
            cities.Clear();
        }
    }
}
