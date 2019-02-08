using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmanSys
{
    public partial class BookingsForm : Form
    {
        BookingsDbConn mysqlConn;
        public BookingsForm()
        {
            InitializeComponent();
            mysqlConn = new BookingsDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateBooking(tbBookingID.Text, tbCustomerID.Text, tbFlightID.Text, dtBookingDateTime.Text, tbBookingTotalCost.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteBooking(tbBookingID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
                }
            mysqlConn.connClose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbBookingID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbCustomerID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbFlightID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dtBookingDateTime.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbBookingTotalCost.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }
    }
}
