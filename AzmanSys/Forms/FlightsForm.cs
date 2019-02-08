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
    public partial class FlightsForm : Form
    {
        FlightsDbConn mysqlConn;
        public FlightsForm()
        {
            InitializeComponent();
            mysqlConn = new FlightsDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.insertFlight(dtDepartureDateTime.Text,dtArrivalDateTime.Text,tbDepartureCity.Text,tbArrivalCity.Text,tbPrice.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateFlight(tbFlightID.Text, dtDepartureDateTime.Text, dtArrivalDateTime.Text, tbDepartureCity.Text, tbArrivalCity.Text, tbPrice.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbFlightID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dtDepartureDateTime.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dtArrivalDateTime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbDepartureCity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbArrivalCity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tbPrice.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight` where F_Departure_City='"+tbDepartureCity.Text+"' Or F_Arrival_City='"+tbArrivalCity.Text+"'").Tables[0];
            }
            mysqlConn.connClose();
        }
    }
}
