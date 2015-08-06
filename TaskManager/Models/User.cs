using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class User
    {
        /// <summary>
        /// The user id associated in the database
        /// </summary>
        private int _userId;

        /// <summary>
        /// The first name of the user
        /// </summary>
        private string _firstName;

        /// <summary>
        /// The email of the user
        /// </summary>
        private string _email;

        /// <summary>
        /// The last name of the user
        /// </summary>
        private string _lastName;

        /// <summary>
        /// The personal number of the user
        /// </summary>
        private string _workPhoneNumber;

        /// <summary>
        /// The user object assigned to each task
        /// </summary>
        /// <param name="userId">the user id associated to the db</param>
        /// <param name="firstName">the first name of the user</param>
        /// <param name="lastName">the last name of the user</param>
        /// <param name="workPhoneNumber">the work number of the user</param>
        public User(int userId, string firstName, string lastName,string email, string workPhoneNumber)
        {
            this._userId = userId;
            this._firstName = firstName;
            this._lastName = lastName;
            this._workPhoneNumber = workPhoneNumber;
            this._email = email;
        }


    }
}
