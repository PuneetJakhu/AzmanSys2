namespace AzmanSys
{
    partial class BookingsForm
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
            this.tbFlightID = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.tbBookingID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbBookingTotalCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBookingDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFlightID
            // 
            this.tbFlightID.Location = new System.Drawing.Point(89, 146);
            this.tbFlightID.Name = "tbFlightID";
            this.tbFlightID.Size = new System.Drawing.Size(100, 20);
            this.tbFlightID.TabIndex = 22;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(89, 98);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerID.TabIndex = 21;
            // 
            // tbBookingID
            // 
            this.tbBookingID.Enabled = false;
            this.tbBookingID.Location = new System.Drawing.Point(89, 49);
            this.tbBookingID.Name = "tbBookingID";
            this.tbBookingID.ReadOnly = true;
            this.tbBookingID.Size = new System.Drawing.Size(100, 20);
            this.tbBookingID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Booking Date and Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Flight ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Booking ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(507, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(507, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(507, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 198);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 229);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tbBookingTotalCost
            // 
            this.tbBookingTotalCost.Location = new System.Drawing.Point(250, 127);
            this.tbBookingTotalCost.Name = "tbBookingTotalCost";
            this.tbBookingTotalCost.Size = new System.Drawing.Size(100, 20);
            this.tbBookingTotalCost.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Cost";
            // 
            // dtBookingDateTime
            // 
            this.dtBookingDateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtBookingDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBookingDateTime.Location = new System.Drawing.Point(250, 76);
            this.dtBookingDateTime.Name = "dtBookingDateTime";
            this.dtBookingDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtBookingDateTime.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(469, 169);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(123, 23);
            this.btnMainMenu.TabIndex = 35;
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.dtBookingDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBookingTotalCost);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbFlightID);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.tbBookingID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "BookingsForm";
            this.Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFlightID;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.TextBox tbBookingID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbBookingTotalCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBookingDateTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainMenu;
    }
}