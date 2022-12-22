using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class FileManager
    {
        private const string fileVersionToken = "ToDoRe_21";
        private const double fileVersionNr = 1.0;
        /// <summary>
        /// Method to save all tasks to file
        /// </summary>
        /// <param name="taskList">List of tasks to save</param>
        /// <param name="fileName">File name to save</param>
        /// <returns></returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(taskList.Count);
                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].description);
                    writer.WriteLine(taskList[i].priority.ToString());
                    writer.WriteLine(taskList[i].dateTime.Year);
                    writer.WriteLine(taskList[i].dateTime.Month);
                    writer.WriteLine(taskList[i].dateTime.Day);
                    writer.WriteLine(taskList[i].dateTime.Hour);
                    writer.WriteLine(taskList[i].dateTime.Minute);
                    writer.WriteLine(taskList[i].dateTime.Second);
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// Method to read a file and import data
        /// </summary>
        /// <param name="taskList">List of task referenced</param>
        /// <param name="fileName">Filename to save</param>
        /// <returns></returns>
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                if (taskList != null)
                {
                    taskList.Clear();
                }
                else
                {
                    taskList = new();
                }
                reader = new StreamReader(fileName);
                string versionTest = reader.ReadLine();
                double version = int.Parse(reader.ReadLine());
                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new();
                        task.description = reader.ReadLine();
                        task.priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());
                        int year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0;
                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());
                        task.dateTime = new DateTime(year, month, day, hour, minute, second);
                        taskList.Add(task);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
    }
}
