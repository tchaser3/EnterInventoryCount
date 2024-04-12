/* Title:           Select Warehouse
 * Date:            12-1-16
 * Author:          Terry Holmes
 * 
 * Description:     This form will alow the user to select the warehouse */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagesDLL;
using EventLogDLL;

namespace EnterInventoryCount
{
    public partial class SelectWarehouse : Form
    {
        //setting the classes
        MessagesClass TheMessagesClass = new MessagesClass();
        EventLogClass TheEventLogClass = new EventLogClass();

        public SelectWarehouse()
        {
            InitializeComponent();
        }

        private void SelectWarehouse_Load(object sender, EventArgs e)
        {
            //setting up the form load
            int intCounter;
            int intNumberOfRecords;

            try
            {
                cboSelectWarehouse.Items.Add("Select Warehouse");

                intNumberOfRecords = Logon.TheWarehousesDataSet.warehouses.Rows.Count - 1;

                //loop
                for(intCounter = 0; intCounter <= intNumberOfRecords; intCounter++)
                {
                    cboSelectWarehouse.Items.Add(Logon.TheWarehousesDataSet.warehouses[intCounter].WarehouseName);
                }

                cboSelectWarehouse.SelectedIndex = 0;
            }
            catch (Exception Ex)
            {
                TheMessagesClass.ErrorMessage(Ex.ToString());

                TheEventLogClass.CreateEventLogEntry("Enter Inventory Count Select Warehouse Form Load " + Ex.Message);
            }
        }

        private void cboSelectWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //setting local variables
            int intCounter;
            int intNumberOfRecords;
            string strWarehouseName;

            try
            {
                Logon.TheSelectedWarehouse.warehouses.Rows.Clear();

                if (cboSelectWarehouse.Text != "Select Warehouse")
                {
                    intNumberOfRecords = Logon.TheWarehousesDataSet.warehouses.Rows.Count - 1;

                    strWarehouseName = cboSelectWarehouse.Text;

                    //loop
                    for (intCounter = 0; intCounter <= intNumberOfRecords; intCounter++)
                    {
                        if (Logon.TheWarehousesDataSet.warehouses[intCounter].WarehouseName == strWarehouseName)
                        {
                            WarehousesDataSet.warehousesRow NewTableRow = Logon.TheSelectedWarehouse.warehouses.NewwarehousesRow();

                            NewTableRow.WarehouseName = Logon.TheWarehousesDataSet.warehouses[intCounter].WarehouseName;
                            NewTableRow.WarehouseID = Logon.TheWarehousesDataSet.warehouses[intCounter].WarehouseID;

                            Logon.TheSelectedWarehouse.warehouses.Rows.Add(NewTableRow);

                            EnterInventory EnterInventory = new EnterInventory();
                            EnterInventory.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                TheMessagesClass.ErrorMessage(Ex.ToString());

                TheEventLogClass.CreateEventLogEntry("Enter Inventory Count Select Warehouse CBO Selected Index Change " + Ex.Message);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this will close the application
            TheMessagesClass.CloseTheProgram();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Logon Logon = new Logon();
            Logon.Show();
            this.Close();
        }
    }
}
