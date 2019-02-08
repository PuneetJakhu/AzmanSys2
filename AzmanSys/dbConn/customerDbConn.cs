using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class customerDbConn: dbConn
    {
        public void insertCustomer(string CusFName, string CusLName, string CusTelNum)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblCustomer` (`CusID`, `CusFName`, `CusLName`, `CusTelNum`) VALUES (NULL,@CusFName, @CusLName, @CusTelNum);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateCustomer(string CusID, string FName, string LName, string Tel)
        {
           
        }

        public void deleteCustomer(string CusID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblCustomer` WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
