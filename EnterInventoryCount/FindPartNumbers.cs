using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterInventoryCount
{
    public partial class FindPartNumbers : Form
    {
        public FindPartNumbers()
        {
            InitializeComponent();
        }

        private void FindPartNumbers_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = EnterInventory.ThePartNumberDataSet.partnumbers;
        }
    }
}
