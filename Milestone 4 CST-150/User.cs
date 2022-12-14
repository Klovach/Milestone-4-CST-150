using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_4_CST_150
{
    internal class User
    {
        // Declare variables
        private string password;
        private int employeeID;
        private int storeID;


        // User Constructor
        public User(string password, int employeeID, int storeID)
        {
            this.password = password;
            this.employeeID = employeeID;
            this.storeID = storeID;
        }

        // Getters
        public string getPassword()
        {
            return password;
        }

        public int getEmployeeID()
        {
            return employeeID;
        }

        public int getStoreID()
        {
            return storeID;
        }
    }
}
