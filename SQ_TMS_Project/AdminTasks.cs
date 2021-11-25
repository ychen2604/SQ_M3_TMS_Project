using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS_Project
{
    public class AdminTasks
    {
        public bool ReviewLogFiles(string filePath)
        {
            try
            {
                // review the file
                return true;
            }
            catch(Exception)
            {
                // Exception if file not present
                return false;
            }
        }

        public bool AlterTable(string tableName, string query)
        {

            return true;
        }

        public bool BackUp(int value)
        {
            if(value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
