using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class TaskManager
    {
        private List<Task> taskList = new();
        /// <summary>
        /// Method to add a task to the list
        /// </summary>
        /// <param name="task">task to add</param>
        public void AddTask(Task task)
        {
            taskList.Add(task);
        }
        /// <summary>
        /// Method to remove the task from the list given the index
        /// </summary>
        /// <param name="index">index of the task to remove</param>
        public void RemoveTask(int index)
        {
            taskList.RemoveAt(index);
        }
        /// <summary>
        /// Method to retrieve the task list
        /// </summary>
        public List<Task> getTaskList()
        {
            return taskList;
        }
        /// <summary>
        /// Method to retrieve the task at given index
        /// </summary>
        /// <param name="index">index</param>
        public Task getTaskAt(int index)
        {
            return taskList[index];
        }
        /// <summary>
        /// Method to change the task at given index
        /// </summary>
        /// <param name="task">index</param>
        /// <param name="index">index</param>
        public void ChangeTask(Task task, int index)
        {
            taskList[index].description = task.description;
            taskList[index].dateTime = task.dateTime;
            taskList[index].priority = task.priority;
        }
        /// <summary>
        /// Method to change read from file
        /// </summary>
        /// <param name="filename">file to read into</param>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fm = new FileManager();
            return fm.ReadTaskListFromFile(taskList, fileName);
        }
        /// <summary>
        /// Method to change write from file
        /// </summary>
        /// <param name="filename">file to write into</param>
        public bool WriteDataFromFile(string fileName)
        {
            FileManager fm = new FileManager();
            return fm.SaveTaskListToFile(taskList, fileName);
        }
    }
}
