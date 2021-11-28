/*
*   FILE        :   PlannerTasks.cs 
*	CLASS	    :	PlannerTasks
*	PURPOSE     :	The purpose of this class is to model Planner Tasks
*
*				Data Members: N/A
*				
*				Properties: N/A
*
*				Methods:
*				1. ReceiversOrder              - receiver a order from buyer
*				2. SelectCarriers              - selsect a carrier for an order
*				3. WhenSplitToMultipleTrips    - split the order for different carriers
*				4. OneDayIncrements            - simulate the passage of time in 1-day increments in order to mover Orders and their trips to completed state 
*				5. ConfirmOrderCompleted       - confirm order
*				6. PrintSummary                -print 3 different type of summary
*
*	AUTHOR	:	Zijia Cao
*/

/// 
/// \class PlannerTasks
///
/// \brief The purpose of this class is to model PlannerTasks. The Planner employee is responsible for furthering the order by selecting one or more registered 
/// Carriers to fulfill the Order, in the form of Trips. Once assigned, the Planner monitors the progression of
/// time in the application, ensuring that when all Trips on an order are completed, the Order will be 
/// marked as Completed and sent back to the Buyer for Invoice Generation. Finally, the Planner may also 
/// produce reports showing aggregate activity in OSHT
/// 1 Planner receives Orders from the Buyer.
/// 2 Planner selects Carriers from the targeted cities to complete the Order, which adds a ‘Trip’ to the Order for each Carrier selected.
/// 3 Carriers may be limited in their transportation capacity, thus the Planner ensures that 
/// multiple Trips, if necessary are attached to the Order.
/// 4 The Planner may simulate the passage of time in 1-day increments in order to mover 
/// Orders and their trips to completed state
/// 5 Planner may confirm an order is completed. Completed Orders are marked for follow-up 
/// from the Buyer
/// 6 Planner may see a summary of all active Orders in a status screen. 
/// 7 Planner may generate a summary report of all Invoice data for a) all time, and b) The 
/// ‘past 2 weeks’ of simulated time
///
/// Data Members: N/A
///
/// Methods:
///    - method to receiver a order from buyer
///    - method to selsect a carrier for an order
///    - method to split the order for different carriers
///    - method to simulate the passage of time in 1-day increments in order to mover Orders and their trips to completed state 
///    - method to confirm order
///    - method to print 3 different type of summary
///
/// \author <i>Zijia Cao</i>
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TMS_Project
{
    public class PlannerTasks
    {

        /**
        *	\brief this function can recevier the order from buyer
        *	\details this method returns whether order received or not
        *	\param int BuyerID, int OrderID
        *	\returns status of the task
        */
        public bool ReceiversOrder(int BuyerID, int OrderID)
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
        *	\brief this function can select a carrier for a order based on city
        *	\details this method returns the carrierID that been selected
        *	\param int OrderID,int CityID
        *	\returns int CarrierID
        */
        public int SelectCarriers(int OrderID, int CityID)
        {
            if(OrderID == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /**
        *	\brief this function can select a carrier for a order based on city, this time, is the order have more item than carrier can carry
        *	\details this method returns the carrierIDs that been selected
        *	\param int OrderID,int CityID
        *	\returns int[] carrierArray
        */
        public int[] WhenSplitToMultipleTrips(int OrderID, int CityID)
        {

            int[] carrierArray = new int[50];
            return carrierArray;
        }

        /**
        *	\brief this function can simulate the passage of time in 1-day increments in order to mover Orders and their trips to completed state 
        *	\details this method returns integer value
        *	\param int OrderID
        *	\returns integer value
        */
        public int OneDayIncrements(int OrderID)
        {
            if (OrderID == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /**
       *	\brief this function can confirm an order is completed. Completed Orders are marked for follow-up from the Buyer 
       *	\details this method returns status of the order execution
       *	\param int OrderID
       *	\returns status
       */
        public bool ConfirmOrderCompleted(int OrderID)
        {
            try
            {
                //change the order state in sql database
                return true;
            }
            catch (Exception)
            {
                // query exception
                return false;
            }
            
        }

        /**
      *	\brief this function can  see a summary of all active Orders in a status screen or generate a summary report
      *	\details this method returns mode of the print summary
      *	\param int mode: to print to screen or generate a summary by time.
      *	\returns mode of the print summary
      */
        public int PrintSummary(int mode)
        {
            switch (mode)
            {
                case 0://print on screen
                    return 0;
                case 1://generate all-time summary
                    return 1;
                case 2://generate past 2 week summary
                    return 2;
                default:
                    return 10;
            }
        }
    }
}
