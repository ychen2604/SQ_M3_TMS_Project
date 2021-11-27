/*
*   FILE    :   AdminTasks.cs 
*	CLASS	:	AdminTasks
*	PURPOSE :	The purpose of this class is to model AdminTasks
*
*				Data Members: N/A
*				
*				Properties: N/A
*
*				Methods:
*				1. ReviewLogFiles               - Review log history
*				2. AlterTable                   - To update table with queries
*				3. BackUp                       - To check backup fail or pass
*
*	AUTHOR	:	Mita Das
*/

/// 
/// \class AdminTasks
///
/// \brief The purpose of this class is to model AdminTasks. The Admin user role represents an individual 
/// at OSHT who has IT experience and is tasked with configuration, maintenance, and troubleshooting of the
/// TMS application.
/// 1. Admin may access general configuration options for TMS, such as selecting directories for log files,
/// targeting IP address and ports for all DBMS communications; etc.
/// 2. Admin may review logfiles without leaving the TMS application.
/// 3. Admin may alter the following, key TMS data:
///      i. Rate / Fee Tables
///     ii. Carrier Data(e.g.to add, update, or delete Carrier information)
///    iii. Route Table
/// 4. Admin may initiate a backup job on the local TMS Database, specifying the directory for the backup files
/// to be produced.
///
/// Data Members: N/A
///
/// Methods:
///    - method to review log file
///    - method to update the table with queries
///    - method to check backup fail or pass
///
/// \author <i>Mita Das</i>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS_Project
{
    public class AdminTasks
    {

        /**
        *	\brief this function reviews log files
        *	\details this method returns status of the review regarding the file
        *	\param string filePath
        *	\returns bool status
        */
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

        /**
        *	\brief this function updates table with queries
        *	\details this method returns status of the query
        *	\param string tableName and string query
        *	\returns bool status
        */
        public bool AlterTable(string tableName, string query)
        {
            try
            {
                // query successful
                return true;
            }
            catch (Exception)
            {
                // query exception
                return false;
            }
        }

        /**
        *	\brief this function checks database backup fail or pass
        *	\details this method returns status of the backup
        *	\param int value
        *	\returns bool status
        */
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
