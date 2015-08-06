using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Enums;

namespace TaskManager.Models
{

    public class Tasks
    {
        /// <summary>
        /// The name of the Child Task
        /// </summary>
        private String _name;

        /// <summary>
        /// The description of the tasks
        /// </summary>
        private String _description;

        /// <summary>
        /// The Date when The Child Task is due 
        /// </summary>
        private DateTime _taskDueDate;

        /// <summary>
        /// Time left before the Child Task is due
        /// </summary>
        private TimeSpan _timeDuration = new TimeSpan(0);

        /// <summary>
        /// The state of importance of the task (low,medium,high,etc).
        /// </summary>
        private ImportanceType _importanceLevel;

        /// <summary>
        /// The state of progress of the task. In progress, started, stopped, etc.
        /// </summary>
        private ProgressType _progressStatus;

        /// <summary>
        /// The task constructor for initializing a new task
        /// </summary>
        /// <param name="name"the name of the task></param>
        /// <param name="description">the description of the task</param>
        /// <param name="dueDate">the due date of the task</param>
        /// <param name="progressType">the progress status </param>
        /// <param name="importanceType">the importance level of the task</param>
        /// <param name="users">the list of users associated to the task</param>
        public Tasks(String name, String description, DateTime dueDate, ProgressType progressStatus, 
                        ImportanceType importanceLevel, List<User> users)
        {
            this._name = name;
            this._description = description;
            this._taskDueDate = dueDate;
            this._progressStatus = progressStatus;
            this._importanceLevel = importanceLevel;
        }



    }

}
