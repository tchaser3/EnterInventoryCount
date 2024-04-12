/* Title:           Enter Inventory
 * Date:            12-1-16
 * Author:          Terry Holmes
 * 
 * Description:     This will Enter the Inventory */

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
using InventoryDLL;
using PartNumberDLL;
using DataValidationDLL;
using EventLogDLL;
using KeyWordDLL;

namespace EnterInventoryCount
{
    public partial class EnterInventory : Form
    {
        MessagesClass TheMessagesClass = new MessagesClass();
        InventoryClass TheInventoryClass = new InventoryClass();
        PartNumberClass ThePartNumberClass = new PartNumberClass();
        DataValidationClass TheDataValidationClass = new DataValidationClass();
        EventLogClass TheEventLogClass = new EventLogClass();
        KeyWordClass TheKeyWordClass = new KeyWordClass();

        public static PartNumbersDataSet ThePartNumberDataSet;

        public EnterInventory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this will close the program
            TheMessagesClass.CloseTheProgram();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Logon Logon = new Logon();
            Logon.Show();
            this.Close();
        }

        private void btnSelectWarehouse_Click(object sender, EventArgs e)
        {
            SelectWarehouse SelectWarehouse = new SelectWarehouse();
            SelectWarehouse.Show();
            this.Close();
        }

        private void EnterInventory_Load(object sender, EventArgs e)
        {
            

            
        }

        private void txtPartNumber_TextChanged(object sender, EventArgs e)
        {
            string strPartDescription;

            strPartDescription = txtPartNumber.Text;

            if(strPartDescription.Length >= 5)
            {
                strPartDescription = "%" + strPartDescription + "%";

                ThePartNumberDataSet = ThePartNumberClass.GetPartNumberByDescriptionKey(strPartDescription);

                FindPartNumbers FindPartNumbers = new FindPartNumbers();
                FindPartNumbers.ShowDialog();
            }
        }
    }
}
