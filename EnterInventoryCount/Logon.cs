/* Title:           Logon
 * Date:            12-1-16
 * Author:          Terry Holmes
 * 
 * Description:     This form will be used to put in the inventory count
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeDLL;
using EventLogDLL;
using MessagesDLL;
using DataValidationDLL;
using KeyWordDLL;

namespace EnterInventoryCount
{
    public partial class Logon : Form
    {
        //setting up the classes
        MessagesClass TheMessagesClass = new MessagesClass();
        EmployeeClass theEmployeeClass = new EmployeeClass();
        EventLogClass TheEventLogClass = new EventLogClass();
        DataValidationClass TheDataValidationClass = new DataValidationClass();
        KeyWordClass TheKeyWordClass = new KeyWordClass();

        //setting variables
        int gintNumberOfMisses;
       
        //setting up the data
        public static EmployeeDataSet TheSearchedEmployeeDataSet;
        public static WarehousesDataSet TheWarehousesDataSet = new WarehousesDataSet();
        public static WarehousesDataSet TheSelectedWarehouse = new WarehousesDataSet();
        EmployeeDataSet TheAllWarehousesDataSet;

        public Logon()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this will close the application
            TheMessagesClass.CloseTheProgram();
        }

        private void Logon_Load(object sender, EventArgs e)
        {
            //creating local variables
            int intCounter;
            int intNumberOfRecords;
            bool blnKeyWordNotFound;

            try
            {
                //setting the variables
                gintNumberOfMisses = 0;

                TheWarehousesDataSet.warehouses.Rows.Clear();

                //getting the warehouses
                TheAllWarehousesDataSet = theEmployeeClass.GetWarehouses();

                //setting the records
                intNumberOfRecords = TheAllWarehousesDataSet.employees.Rows.Count - 1;

                for(intCounter = 0; intCounter <= intNumberOfRecords; intCounter++)
                {
                    blnKeyWordNotFound = TheKeyWordClass.FindKeyWord("JH", TheAllWarehousesDataSet.employees[intCounter].FirstName);

                    if(blnKeyWordNotFound == false)
                    {
                        WarehousesDataSet.warehousesRow NewTableRow = TheWarehousesDataSet.warehouses.NewwarehousesRow();

                        NewTableRow.WarehouseName = TheAllWarehousesDataSet.employees[intCounter].FirstName;
                        NewTableRow.WarehouseID = TheAllWarehousesDataSet.employees[intCounter].EmployeeID;

                        //adding the row
                        TheWarehousesDataSet.warehouses.Rows.Add(NewTableRow);
                    }
                }
            }
            catch (Exception Ex)
            {
                TheEventLogClass.CreateEventLogEntry("Enter Inventory Count Logon Form Load " + Ex.Message);

                TheMessagesClass.ErrorMessage(Ex.ToString());
            }

           
        }
        private void LogonFailure()
        {
            //updaing the number of misses
            gintNumberOfMisses++;

            if(gintNumberOfMisses < 3)
            {
                TheMessagesClass.InformationMessage("The Logon Information is Incorrect");
            }
            if(gintNumberOfMisses == 3)
            {
                TheEventLogClass.CreateEventLogEntry("There Have Been Three Attemps to Log on to Enter Inventory Count");
                TheMessagesClass.ErrorMessage("There Have Been Three Attempts To Logon\nThe Applicaiton Will close");
                Application.Exit();
            }
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            //setting local variables
            string strValueForValidation;
            bool blnFatalError = false;
            bool blnThereIsAProblem = false;
            string strErrorMessage = "";
            int intRecordsFound;
            int intEmployeeID = 0;
            string strLastName;

            //performing data validation
            strValueForValidation = txtEmployeeID.Text;
            blnFatalError = TheDataValidationClass.VerifyIntegerData(strValueForValidation);
            if(blnFatalError ==true)
            {
                blnThereIsAProblem = true;
                strErrorMessage = strErrorMessage + "The Employee ID is not a Integer\n";
            }
            else
            {
                intEmployeeID = Convert.ToInt32(strValueForValidation);
            }
            strLastName = txtLogonLastName.Text;
            if(strLastName == "")
            {
                blnThereIsAProblem = true;
                strErrorMessage = strErrorMessage + "The Last Name Was Not Entered";
            }
            if(blnThereIsAProblem == true)
            {
                TheMessagesClass.ErrorMessage(strErrorMessage);
                return;
            }

            //getting the employee information
            TheSearchedEmployeeDataSet = theEmployeeClass.FindEmployeeByID(intEmployeeID);

            intRecordsFound = TheSearchedEmployeeDataSet.employees.Rows.Count;

            if(intRecordsFound == 1)
            {
                if(strLastName == TheSearchedEmployeeDataSet.employees[0].LastName)
                {
                    SelectWarehouse SelectWarehouse = new SelectWarehouse();
                    SelectWarehouse.Show();
                    this.Hide();
                }
                else
                {
                    LogonFailure();
                }
            }
            else
            {
                LogonFailure();
            }
        }
    }
}
