namespace EnterInventoryCount
{
    partial class EnterInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectWarehouse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnViewEnteredInformation = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarehouseID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(322, 277);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(142, 54);
            this.btnLogOff.TabIndex = 7;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(322, 335);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 54);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectWarehouse
            // 
            this.btnSelectWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectWarehouse.Location = new System.Drawing.Point(322, 219);
            this.btnSelectWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectWarehouse.Name = "btnSelectWarehouse";
            this.btnSelectWarehouse.Size = new System.Drawing.Size(142, 54);
            this.btnSelectWarehouse.TabIndex = 6;
            this.btnSelectWarehouse.Text = "Select Warehouse";
            this.btnSelectWarehouse.UseVisualStyleBackColor = true;
            this.btnSelectWarehouse.Click += new System.EventHandler(this.btnSelectWarehouse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnterInventoryCount.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(183, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(11, 90);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(453, 41);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "Enter Inventory Counts";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewEnteredInformation
            // 
            this.btnViewEnteredInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEnteredInformation.Location = new System.Drawing.Point(322, 161);
            this.btnViewEnteredInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewEnteredInformation.Name = "btnViewEnteredInformation";
            this.btnViewEnteredInformation.Size = new System.Drawing.Size(142, 54);
            this.btnViewEnteredInformation.TabIndex = 5;
            this.btnViewEnteredInformation.Text = "View Entered Information";
            this.btnViewEnteredInformation.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(24, 204);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(137, 26);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "Quantity";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AcceptsReturn = true;
            this.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(178, 205);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(106, 26);
            this.txtQuantity.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(24, 174);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(137, 26);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Part Number";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.AcceptsReturn = true;
            this.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNumber.Location = new System.Drawing.Point(178, 175);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(106, 26);
            this.txtPartNumber.TabIndex = 0;
            this.txtPartNumber.TextChanged += new System.EventHandler(this.txtPartNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLocation
            // 
            this.txtLocation.AcceptsReturn = true;
            this.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(178, 265);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(106, 26);
            this.txtLocation.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 59;
            this.label5.Text = "Warehouse ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.AcceptsReturn = true;
            this.txtWarehouseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWarehouseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseID.Location = new System.Drawing.Point(178, 235);
            this.txtWarehouseID.Margin = new System.Windows.Forms.Padding(2);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.ReadOnly = true;
            this.txtWarehouseID.Size = new System.Drawing.Size(106, 26);
            this.txtWarehouseID.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(87, 306);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 54);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // EnterInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 403);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWarehouseID);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.btnViewEnteredInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSelectWarehouse);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnClose);
            this.Name = "EnterInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterInventory";
            this.Load += new System.EventHandler(this.EnterInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectWarehouse;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnViewEnteredInformation;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPartNumber;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtLocation;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtWarehouseID;
        private System.Windows.Forms.Button btnSave;
    }
}