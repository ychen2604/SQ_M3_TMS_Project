/*
* FILE    :   BuyerTasks.cs 
*	CLASS	  :	  BuyerTasks
*	PURPOSE :	  The purpose of this class is to model BuyerTasks
*
*				Data Members: N/A
*				
*				Properties: N/A
*
*				Methods:
*				1. ReviewCustomer               - Review existing Customers and accept new Customer
*				2. IntiateNewOrder              - Initiate a new Order from the Marketplace requests
*				3. SelectCities                 - Select relevant Cities for the Order
*				4. InvoiceGeneration            - Review completed Orders and process them for Invoice Generation
*
*	AUTHOR	:	Aryandeep Ratti
*/

/// 
/// \class BuyerTasks
///
/// \brief The purpose of this class is to model BuyerTasks. The buyer represents an employee of OSHT who is tasked with requesting Customer contracts from the 
/// Contract Marketplace and generating an initial Order or contract. Their chief output is an Order, which 
/// is marked for action by the Planner. After the Planner’s work is completed, the Buyer confirms each 
/// completed Order and generates an Invoice to the Customer.
/// 1. Initiates contact with the Contract Marketplace to receive contracts from Customers
/// 2. Buyer may review existing Customers and accept new Customers (from the Marketplace)
/// into the TMS system
/// 3. Buyer may initiate a new Order from the Marketplace requests
/// 4. Buyer may select relevant Cities for the Order. This will nominate Carriers in those Cities 
/// for Order completion (which is confirmed by the Planner)
/// 5. Buyer may review completed Orders and process them for Invoice Generation.
/// 6. Invoice Generation results in a text file being generated with appropriate billing details. 
/// This information is also stored in the TMS database.
///
/// Data Members: N/A
///
/// Methods:
///    - method to review existing Customers and accept new Customer
///    - method to initiate a new Order from the Marketplace requests
///    - method to select relevant Cities for the Order
///    - method to review completed Orders and process them for Invoice Generation
///
/// \author <i>Aryandeep Ratti</i>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS_Project
{
    public class BuyerTasks
    {

        /**
        *	\brief this function reviews existing and new customers in TMS System
        *	\details this method returns status of the existing and new customers
        *	\param string Name
        *	\returns bool status
        */
        public bool ReviewCustomers(string Name)
        {
            try
            {
                // review name
                if(name == true)
                {
                return true;
                }
                else
                {
                // insert new name in TMS System
                }
            }
            catch(Exception)
            {
                // Exception if name not present
                return false;
            }
        }

        /**
        *	\brief this function initiates a new order from the marketplace requests
        *	\details this method returns status of the query
        *	\param string newOrder and string query
        *	\returns bool status
        */
        public bool newOrder(string newOrder, string query)
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
        *	\brief this function selects relevant Cities for the Order
        *	\details this method returns the relevant city
        *	\param string city
        *	\returns bool status
        */
        public bool city(string city)
        {
            if(city == newCity())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /**
        *	\brief this function reviews completed orders and process them for invoice generation
        *	\details this method returns the invoice generation
        *	\param int order
        *	\returns bool status
        */
        public bool invoiceGeneration(int order)
        {
            try
            {
                // order completed, process invoice generation
                return true;
            }
            catch (Exception)
            {
                // query exception
                return false;
            }
        }
        
        /**
        *	\brief this function contians relevent city names
        *	\details this method returns the relevant city
        *	\param string cities
        *	\returns city
        */
        private bool city(string cities)
        {
         var cities = new List<string>()
                    {
                        "Waterloo",
                        "London",
                        "Toronto",
                        "Cambridge"                    
                    };
            
          //select relevent city
          return city; 
        }
       
    }
}
